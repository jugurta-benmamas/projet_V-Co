-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 04 nov. 2024 à 11:02
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projet_vco`
--

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `proc_ajouterCours`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_ajouterCours` (IN `titre` VARCHAR(60), IN `imageCouverture` VARCHAR(255), IN `contenu` TEXT, IN `themeID` INT)   BEGIN
    DECLARE themeExists INT;

    /*Vérifie si le thème existe*/
    SELECT COUNT(*) INTO themeExists FROM Theme WHERE theme_id = themeID;
    IF themeExists = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Thème introuvable';
    ELSE
        INSERT INTO Cours (cours_titre, cours_imageCouverture, cours_contenu, theme_id)
        VALUES (titre, imageCouverture, contenu, themeID);
    END IF;
END$$

DROP PROCEDURE IF EXISTS `proc_ajouterModule`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_ajouterModule` (IN `titre_mod` VARCHAR(50), IN `image_mod` VARCHAR(255))   BEGIN
    INSERT INTO module (mod_titre, mod_image)
    VALUES (titre_mod, image_mod);
END$$

DROP PROCEDURE IF EXISTS `proc_ajouterTheme`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_ajouterTheme` (IN `nom_theme` VARCHAR(30), IN `moduleID` INT)   BEGIN
    DECLARE moduleExists INT;

    /*Vérifie si le module existe*/
    SELECT COUNT(*) INTO moduleExists FROM Module WHERE mod_id = moduleID;
    IF moduleExists = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Module introuvable';
    ELSE
        INSERT INTO Theme (theme_nom, mod_id)
        VALUES (nom_theme, moduleID);
    END IF;
END$$

DROP PROCEDURE IF EXISTS `proc_ajouterUtilisateur`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_ajouterUtilisateur` (IN `uti_nom` VARCHAR(65), IN `uti_prenom` VARCHAR(65), IN `uti_role` VARCHAR(50))   BEGIN
    INSERT INTO utilisateur (uti_nom, uti_prenom, uti_role, uti_login, uti_motPasse)
    VALUES (uti_nom, uti_prenom, uti_role, NULL, NULL); -- NULL pour laisser le trigger générer le mot de passe
END$$

DROP PROCEDURE IF EXISTS `proc_listeCours`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_listeCours` ()   BEGIN
SELECT * FROM cours;
END$$

DROP PROCEDURE IF EXISTS `proc_listeCoursTheme`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_listeCoursTheme` (IN `id_theme` INT)   BEGIN
SELECT * FROM cours WHERE cours.theme_id=id_theme;
END$$

DROP PROCEDURE IF EXISTS `proc_listerModules`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_listerModules` ()   BEGIN
    SELECT mod_id, mod_titre, mod_image FROM module;
END$$

DROP PROCEDURE IF EXISTS `proc_listeTheme`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_listeTheme` ()   BEGIN
SELECT * FROM theme;
END$$

DROP PROCEDURE IF EXISTS `proc_listeThemesModule`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_listeThemesModule` (IN `id_mod` INT)   BEGIN
SELECT * FROM theme WHERE theme.mod_id = id_mod;
END$$

DROP PROCEDURE IF EXISTS `proc_listeUtilisateurs`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_listeUtilisateurs` ()   BEGIN
    SELECT *
    FROM utilisateur;
END$$

DROP PROCEDURE IF EXISTS `proc_marquerCours`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_marquerCours` (IN `utilisateurID` INT, IN `coursID` INT, IN `compris` BOOLEAN)   BEGIN
    INSERT INTO Valider (uti_id, cours_id, compris_OuiNon)
    VALUES (utilisateurID, coursID, TRUE, compris)
    ON DUPLICATE KEY UPDATE fini_OuiNon = TRUE, compris_OuiNon = compris;
    
    /*Mettre à jour la progression si l'utilisateur a compris*/
    IF compris = TRUE THEN
        UPDATE Progression
        SET prog_pourcentage = prog_pourcentage + (100 / (SELECT COUNT(*) FROM Cours WHERE theme_id = (SELECT theme_id FROM Cours WHERE cours_id = coursID)))
        WHERE uti_id = utilisateurID AND cours_id = coursID;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `proc_modifierCours`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_modifierCours` (IN `id_cours` INT, IN `titre_cours` VARCHAR(60), IN `imageCouverture_cours` VARCHAR(255), IN `contenu_cours` TEXT)   BEGIN
    UPDATE cours
    SET cours.cours_titre = titre_cours,
        cours.cours_imageCouverture = imageCouverture_cours,
        cours.cours_contenu = contenu_cours
    WHERE cours.cours_id = id_cours;
END$$

DROP PROCEDURE IF EXISTS `proc_modifierModule`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_modifierModule` (IN `id_mod` INT, IN `titre_mod` VARCHAR(50), IN `image_mod` VARCHAR(255))   BEGIN
    UPDATE module
    SET mod_titre = titre_mod,
        mod_image = image_mod
    WHERE mod_id = id_mod;
END$$

DROP PROCEDURE IF EXISTS `proc_modifierTheme`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_modifierTheme` (IN `id_theme` INT, IN `nom_theme` VARCHAR(30))   BEGIN
    UPDATE theme
    SET theme_nom = nom_theme
    WHERE theme_id = id_theme;
END$$

DROP PROCEDURE IF EXISTS `proc_modifierUtilisateur`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_modifierUtilisateur` (IN `id_uti` INT, IN `nom_uti` VARCHAR(50), IN `prenom_uti` VARCHAR(50), IN `role_uti` ENUM('apprenant','formateur','admin'), IN `login_uti` VARCHAR(50))   BEGIN
    UPDATE utilisateur
    SET 
        uti_nom = nom_uti,
        uti_prenom = prenom_uti,
        uti_login = login_uti,
        uti_role = role_uti
    WHERE uti_id = id_uti;
END$$

DROP PROCEDURE IF EXISTS `proc_statistiqueCours`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_statistiqueCours` (IN `coursID` INT, OUT `pourcentCompris` DECIMAL(5,2), OUT `pourcentPasCompris` DECIMAL(5,2))   BEGIN
    DECLARE totalReponse INT;
    DECLARE totalCompris INT;
    DECLARE totalPasCompris INT;

    /*Récupérer le nombre total de réponses*/
    SELECT COUNT(*) INTO totalReponse
    FROM Valider
    WHERE cours_id = coursID;

    /*Récupérer le nombre de réponses "compris"*/
    SELECT COUNT(*) INTO totalCompris
    FROM Valider
    WHERE cours_id = coursID AND compris_OuiNon = TRUE;

    /*Calculer le nombre de réponses "pas compris"*/
    SET totalPasCompris = totalReponse - totalCompris;

    /*Calculer les pourcentages*/
    IF totalReponse > 0 THEN
        SET pourcentCompris = (totalCompris / totalReponse) * 100;
        SET pourcentPasCompris = (totalPasCompris / totalReponse) * 100;
    ELSE
        SET pourcentCompris = 0;
        SET pourcentPasCompris = 0;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `proc_supprimerCours`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_supprimerCours` (IN `id_cours` INT)   BEGIN
DELETE FROM cours WHERE cours.cours_id = id_cours;
END$$

DROP PROCEDURE IF EXISTS `proc_supprimerModule`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_supprimerModule` (IN `id_mod` INT)   BEGIN
    DELETE FROM module
    WHERE mod_id = id_mod;
END$$

DROP PROCEDURE IF EXISTS `proc_supprimerTheme`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_supprimerTheme` (IN `id_theme` INT)   BEGIN
DELETE FROM theme WHERE theme.theme_id = id_theme;
END$$

DROP PROCEDURE IF EXISTS `proc_supprimerUtilisateur`$$
CREATE DEFINER=`gvargas`@`localhost` PROCEDURE `proc_supprimerUtilisateur` (IN `id_uti` INT)   BEGIN
DELETE FROM utilisateur WHERE uti_id =id_uti;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

DROP TABLE IF EXISTS `cours`;
CREATE TABLE IF NOT EXISTS `cours` (
  `cours_id` int NOT NULL AUTO_INCREMENT,
  `cours_titre` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cours_imageCouverture` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `cours_contenu` text NOT NULL,
  `theme_id` int DEFAULT NULL,
  PRIMARY KEY (`cours_id`),
  KEY `theme_id` (`theme_id`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `cours`
--

INSERT INTO `cours` (`cours_id`, `cours_titre`, `cours_imageCouverture`, `cours_contenu`, `theme_id`) VALUES
(1, 'Attaque par dictionnaire', 'https://i.ytimg.com/vi/qSE7EwmtNCU/hqdefault.jpg', 'L\'attaque par dictionnaire est une méthode utilisée en cryptanalyse pour trouver un mot de passe ou une clé. Elle consiste à tester une série de mots de passe potentiels, les uns à la suite des autres, en espérant que le mot de passe utilisé pour le chiffrement soit contenu dans le dictionnaire', 1),
(2, 'Attaque par dictionnaire', 'https://i.ytimg.com/vi/qSE7EwmtNCU/hqdefault.jpg', 'L\'attaque par dictionnaire est une méthode utilisée en cryptanalyse pour trouver un mot de passe ou une clé. Elle consiste à tester une série de mots de passe potentiels, les uns à la suite des autres, en espérant que le mot de passe utilisé pour le chiffrement soit contenu dans le dictionnaire de jugurta', 1),
(3, 'Bombardement de courriels (Mail bombing) / Mailbomb', 'https://www.howtogeek.com/wp-content/uploads/2019/04/email-bomb.jpg?height=200p&trim=2,2,2,2', 'Envoi d’une grande quantité de courriels à un destinataire unique dans une intention malveillante.\r\nRemarques : Forme particulière de déni de service contre les systèmes de courriers électroniques.\r\n', 1),
(4, 'Bombe programmée, bombe logique (Logic bomb) / Fork Bomb', 'https://tse3.mm.bing.net/th?id=OIP.AqfDmGblfC6uSUAJQ_dMbQHaFj&pid=Api&P=0&h=180', 'Logiciel malveillant conçu pour causer des dommages à un système informatique et qui est déclenché lorsque certaines conditions sont réunies.\r\nRemarques : Certains virus contiennent une fonction de bombe logique : déclenchement à date fixe, déclenchement quand une adresse réticulaire (URL) particulière est renseignée dans le navigateur, etc.\r\n', 1),
(5, 'Clonage de serveur DNS (DNS pharming)', 'https://www.phonerol.com/wp-content/uploads/2023/12/fonctionnement-des-serveurs-dns-img-01-1200x686.jpg', 'Activité malveillante visant à modifier un serveur DNS (serveur de noms de domaine), dans le but de rediriger un nom de domaine vers une adresse IP différente de l’adresse légitime. En croyant aller sur un site connu, l’internaute navigue en réalité sur un site factice.\r\nRemarques : le trafic envoyé au domaine souhaité (organisme bancaire, messagerie électronique, etc.) peut être capturé par un utilisateur malveillant, qui, par exemple, a déjà copié des pages du domaine visé à l’adresse nouvellement indiquée par le DNS. La personne qui se connecte au domaine risque alors d’entrer des informations confidentielles sur le site factice, même si elle a pris la précaution de renseigner l’adresse correcte.\r\n', 1),
(6, 'Code d’exploitation (Exploit)', 'https://tse4.mm.bing.net/th?id=OIP.lqUfKEKH-FKJEn5eETfCngHaE8&pid=Api&P=0&h=180', 'Tout ou partie d’un programme permettant d’utiliser une vulnérabilité ou un ensemble de vulnérabilités d’un logiciel (du système ou d’une application) à des fins malveillantes.\r\n\r\nRemarques : Les objectifs malveillants consistent souvent en une intrusion, une élévation de privilèges ou un déni de service. L’exploitation peut se faire directement à partir du système ciblé si l’utilisateur malveillant possède un accès physique (local exploit), ou à distance s’il s’y connecte (remote exploit) \r\n\r\nGrands types d’exploits\r\n\r\nLes exploits sont souvent classés selon deux types : connu ou inconnu.\r\nLes exploits connus ont déjà été détectés par les chercheurs en cybersécurité. Que ces exploits soient dus à une vulnérabilité dans le logiciel, dans le système d’exploitation ou même dans le matériel, les développeurs peuvent créer des correctifs pour y remédier. Ces correctifs sont publiés sous forme de mises à jour de sécurité pour les utilisateurs. C’est pour cela qu’il est important que vos appareils soient tenus à jour.\r\nLes exploits inconnus, aussi appelés « exploits zero-day » sont quant à eux créés par des cybercriminels dès qu’ils découvrent une vulnérabilité, et ils utilisent cet exploit pour attaquer leurs victimes le jour même. Lorsqu’une attaque d’exploit zero-day se produit, les développeurs de logiciels et les chercheurs en cybersécurité doivent en urgence comprendre comment fonctionne cet exploit et comment corriger la vulnérabilité concernée.\r\nCertains exploits ont débouché sur des cyberattaques d’une telle ampleur qu’ils sont restés célèbres :\r\n\r\nEternalBlue\r\n\r\nEternalBlue est un des exploits les plus célèbres et des plus dangereux. Créé à l’origine par la NSA, EternalBlue a été volé par le groupe de pirates Shadow Brokers, puis diffusé en mars 2017. Bien que Microsoft ait découvert cette fuite et ait publié une mise à jour pour corriger la vulnérabilité visée, de nombreuses personnes ou organisations n’ont pas appliqué ce correctif à temps. Ceci a permis aux pirates de commettre une des cyberattaques les plus dévastatrices parmi celles connues, dont WannaCry et NotPetya.\r\n\r\nWannaCry\r\n\r\nWannaCry était cauchemardesque : une attaque par ver qui utilisait l’exploit EternalBlue pour se répandre de façon exponentielle sur les réseaux informatiques, infectant au passage plus de 10 000 machines toutes les heures dans 150 pays. Dans sa forme de ransomware, WannaCry chiffrait les ordinateurs et les rendait inutilisables, un problème énorme pour les services de santé publique, les administrations, les universités et les grandes entreprises affectées. Bien que WannaCry ne soit plus actif, d’autres exploits peuvent encore s’appuyer sur EternalBlue pour attaquer les utilisateurs Windows qui utilisent des logiciels obsolètes. Vérifiez donc bien que les vôtres sont à jour.\r\n\r\nPetya et NotPetya\r\n\r\nPetya, ainsi que son successeur le bien-nommé NotPetya, étaient des souches de ransomwares (NotPetya s’appuyait aussi sur l’exploit EternalBlue). Les deux Petya ont causé d’énormes dégâts en chiffrant la table de fichiers principale (ou MFT) des ordinateurs, ce qui rendait les machines parfaitement inutilisables. Et bien que des demandes de rançon aient été émises, NotPetya n’a jamais pu être déchiffré. Donc même si les utilisateurs et les entreprises consentaient à mettre la main au portefeuille, rien ne leur était envoyé en retour. D’après les experts, les souches de ransomware Petya ont causé plus de 10 milliards de dollars de dégâts, affectant des banques et de nombreuses autres entreprises.\r\n\r\nBlueKeep\r\n\r\nBlueKeep est une vulnérabilité exploitable dans le protocole Microsoft RDP du Bureau à distance, qui peut permettre aux pirates de se connecter à distance à l’ordinateur de leur victime. Microsoft a sonné l’alarme à propos de BlueKeep en mai 2019 et a publié un correctif, y compris pour les systèmes d’exploitation obsolètes comme Windows XP. Ce comportement inhabituel souligne la gravité potentielle de BlueKeep : comme il s’agissait d’un nouvel exploit sous forme de ver, les experts sécurité craignaient qu’il ne débouche sur de nouvelles cyberattaques massives. Au moment de la publication de cet article, BlueKeep est loin d’avoir eu cet impact, mais il est important d’appliquer les correctifs nécessaires sur votre système afin de vous prémunir de toute attaque à venir. \r\n', 1),
(7, 'IP Spoofing', 'https://shredcube.com/wp-content/uploads/2021/10/IP-Spoofing-1.jpg', 'Action par laquelle un système tente de se faire passer illicitement pour un autre système en utilisant son adresse IP.', 1),
(8, 'Ping of Death', 'https://cyberpedia.reasonlabs.com/IMG/ping%20of%20death.jpg', 'Utilisation d\'un ping avec un paquet de taille supérieure a 65507. Ce type d\'attaque entraîne un Denial of Service.', 1),
(9, 'Spoofing', 'https://www.welivesecurity.com/wp-content/uploads/2019/07/Spoofing-1024x819.jpg', 'Action de se faire passe pour quelqu\'un d\'autre. Incitation délibérée à un utilisateur ou à une ressources à effectuer une action incorrecte. Tentative de gagner l\'accès a un AIS en se faisant passer pour un utilisateur autorisé. Les personnifications (Impersonating), les actions de se masquer (Masquerading), et les simulations (Mimicking) sont des formes de spoofing.', 1),
(10, 'Vulnérabilité (Vulnerability)', 'https://static.wixstatic.com/media/54de26_f2053a4133854230a045ddfe07483467~mv2.jpg/v1/fill/w_4000,h_2666,al_c/54de26_f2053a4133854230a045ddfe07483467~mv2.jpg', 'Faute, par malveillance ou maladresse, dans les spécifications, la conception, la réalisation, l’installation ou la configuration d’un système, ou dans la façon de l’utiliser. Remarques : Une vulnérabilité peut être utilisée par un code d’exploitation et conduire à une intrusion dans le système.', 2),
(11, 'CVE (Common Vulnerabilities and Exposure)', 'https://usercontent.one/wp/www.hyper-ict.com/wp-content/uploads/2024/06/CVE.png', 'Base de données qui répertorie les vulnérabilités connues sur les principaux systèmes. Chaque vulnérabilité est documentée afin d’aider les administrateurs et développeurs lors de leurs analyses en cybersécurité. Un analyste en cybersécurité pourra obtenir de précieux renseignements sur des vulnérabilités déjà répertoriées par exemple suite à un audit lors d’un test d’intrusion.', 2),
(12, 'Zero-Day', 'https://tse3.mm.bing.net/th?id=OIP.oQFPePbA629cvO6gv5BZzwHaDS&pid=Api&P=0&h=180', 'Dans le domaine de la sécurité informatique, une faille / vulnérabilité zero-day — également orthographiée 0-day — ou faille / vulnérabilité du jour zéro est une vulnérabilité informatique n\'ayant fait l\'objet d\'aucune publication ou n\'ayant aucun correctif connu.', 2),
(13, 'Firewall', 'https://tse3.mm.bing.net/th?id=OIP.OvWu4PP_VjTlEYDxXdHbHwHaFj&pid=Api&P=0&h=180', 'Système ou combinaison de systèmes qui renforce la limite entre deux réseaux ou plus.', 3),
(14, 'Network Level Firewall', 'https://techjournal.org/wp-content/uploads/2022/07/Types-of-Firewall-in-Network-Security.jpg', 'Firewall analysant le trafic au niveau des paquets de protocole réseau (IP).', 3),
(15, 'Packet Filtering', 'https://cyberpedia.reasonlabs.com/IMG/packet%20filtering.jpg', 'Limitation du flux d\'informations en fonction de critères prédéfinis comme la source ou la destination.', 3),
(16, 'Balayage de ports (Port scanning)', 'https://info.varonis.com/hs-fs/hubfs/Imported_Blog_Media/Screen-Shot-2021-05-06-at-1_09_04-PM.png?length=1245&name=Screen-Shot-2021-05-06-at-1_09_04-PM.png', 'Technique qui consiste à envoyer des paquets de données sur les différents ports d’une machine, puis à en déduire les états (la disponibilité) de ces ports en fonction de la réponse retournée, si elle existe. \r\nRemarques : Cette technique peut être utilisée pour découvrir les services fonctionnant sur la machine, en faisant une extrapolation entre les ports vus en l’état ouvert, et les services fonctionnant traditionnellement avec ce port. Les paquets de données peuvent être envoyés sur les ports linéairement (l’un à la suite de l’autre), ou bien de manière plus discrète, en modifiant les temps d’envoi des paquets, en les envoyant dans un ordre aléatoire ou à partir de plusieurs adresses IPs.', 3),
(17, 'Canal caché (Covert Channel)', 'https://www.researchgate.net/profile/Matti-Hiltunen/publication/221609235/figure/fig2/AS:667682621886474@1536199350304/An-illustration-of-a-covert-channel-using-L2-cache-to-encode-information-For-each-bit_Q320.jpg', 'Canal de communication qui permet à un processus malveillant de transférer des informations d’une manière dissimulée. Le canal caché assure une communication par l’exploitation d’un mécanisme qui n’est pas censé servir à la communication.\r\n\r\nRemarques : Les canaux cachés sont l’objet de nombreux travaux de recherche, tant pour les créer que pour les détecter.\r\n', 3),
(18, ' Promiscuous Mode', 'https://i.ytimg.com/vi/TFsEgS6LW88/maxresdefault.jpg', 'Habituellement, une interface Ethernet lit toutes les informations d\'adressage et accepte uniquement les paquets lui étant exclusivement destinés; mais quand l\'interface est en Promiscuous Mode, elle lit toutes les informations (sniffer) en portant peu attention à la destination.', 3),
(19, 'Bastion', 'https://www.certilience.fr/wp-content/uploads/2023/05/edr-q6jdpmrlci9rj6a8zd24xd0gaguvwng5mcthbsrhzk.jpg', 'Système de très haut niveau de sécurité́ qui vise à protéger un réseau ou une partie d’un réseau des menaces extérieures.', 3),
(20, 'Chiffrement', 'https://www.virtru.com/hubfs/Imported_Blog_Media/encryptionkey-2.jpg', 'Transformation cryptographique de données produisant un cryptogramme.', 4),
(21, 'Cryptanalyse', 'https://wilku.top/wp-content/uploads/2023/02/What-is-Cryptanalysis-and-How-Does-it-Work.png', 'Processus de déchiffrement de données protégées au moyen de cryptographie sans être en possession des clés de chiffrement.', 4),
(22, 'Cryptographie', 'https://tse4.mm.bing.net/th?id=OIP.XlSsENicVDGEq5UEjs8LFAHaEL&pid=Api&P=0&h=180', 'Discipline incluant les principes, moyens et méthodes de transformation des données, dans le but de cacher leur contenu, d’empêcher que leur modification ne passe inaperçue et/ou d’empêcher leur utilisation non autorisée (ISO 7498-2).', 4),
(23, 'Cryptologie', 'https://thumbs.dreamstime.com/b/concept-de-cryptologie-81466898.jpg', 'Science englobant la cryptographie et la cryptanalyse.\r\nLa cryptologie, littéralement science du secret en grec, a longtemps été associée à de mystérieux enjeux d’espionnage militaire et diplomatique bien éloignés des préoccupations scientifiques habituelles. Après s’être longtemps résumée à un jeu sans fondements théoriques profonds entre ingénieux concepteurs de codes secrets et cryptanalystes acharnés, elle s’est transformée, à l’aube du XXIe siècle, en une science dynamique à l’intersection de nombreuses autres plus orthodoxes telles que les mathématiques, l’informatique et la micro-électronique.\r\n', 4),
(24, 'PGP (Pretty Good Privacy)', 'https://tse2.mm.bing.net/th?id=OIP.4GsbQioBcbJktdjLTn5YTQHaE7&pid=Api&P=0&h=180', 'Programme gratuit (freeware) utilisé principalement pour sécuriser le courrier électronique.', 4),
(25, 'Confidentialité', 'https://tse4.mm.bing.net/th?id=OIP.y46P-jsAKjxwZQhg9NXXqAHaCl&pid=Api&P=0&h=180', 'Propriété d’une information qui n’est ni disponible, ni divulguée aux personnes, entités ou processus non autorisés.', 5),
(26, 'Charge Utile (Payload)', 'https://tse4.mm.bing.net/th?id=OIP.KnMm_zNr3kl6w_-YwxAxdwAAAA&pid=Api&P=0&h=180', 'Le payload ou charge utile est la partie du code malveillante qui permet l’exploitation d’une vulnérabilité. Cette partie de code peut contenir des vers ou des virus par exemple.', 5),
(27, 'Non-Répudiation', 'https://tse4.mm.bing.net/th?id=OIP.8K5vQUNHXhY6QuBXdz7JZwAAAA&pid=Api&P=0&h=180', 'Méthode par laquelle l\'expéditeur de données donne une preuve d\'envoi et le receveur est assuré de l\'identité de l\'expéditeur, pour que personne ne puisse, par la suite, nier avoir traité ces données.', 5),
(28, 'Authentification / identification', 'https://tse4.mm.bing.net/th?id=OIP.h1G7cwdlDqGnTfd7kKkKigHaEK&pid=Api&P=0&h=180', 'L’authentification a pour but de vérifier l’identité dont une entité se réclame. Généralement l’authentification est précédée d’une identification qui permet à cette entité de se faire reconnaître du système par un élément dont on l’a doté. En résumé, s’identifier c’est communiquer son identité, s’authentifier c’est apporter la preuve de son identité.', 6),
(29, 'Authentification à deux facteurs (2FA)', 'https://tse4.mm.bing.net/th?id=OIP.mW1oxLcMmvmTCoZIrSuSSQHaEK&pid=Api&P=0&h=180', 'La double authentification, authentification à deux facteurs (A2F)1, authentification à double facteur ou vérification en deux étapes (two-factor authentication en anglais, ou 2FA) est une méthode d\'authentification forte par laquelle un utilisateur peut accéder à une ressource informatique (un ordinateur, un téléphone intelligent ou encore un site web) après avoir présenté deux preuves d\'identité distinctes à un mécanisme d\'authentification. Un exemple de ce processus est l\'accès à un compte bancaire grâce à un guichet automatique bancaire : seule la combinaison de la carte bancaire (que l\'usager détient) et du numéro d\'identification personnel (que l\'usager connaît) permet de consulter le solde du compte et de retirer de l\'argent.', 6),
(30, 'Authentification unique (Single Sign-On)', 'https://tse3.mm.bing.net/th?id=OIP.As7x3BOjwTchogH3_Ye3vAHaE7&pid=Api&P=0&h=180', 'Méthode qui permet à un utilisateur d’accéder à plusieurs applications informatiques sécurisées en ne procédant qu’à une seule authentification.', 5),
(31, 'Compte privilégié', 'https://assets-global.website-files.com/61360238fb865f856980c0c7/652d0caeb4f9def31aa9d0fa_gestion-compte-privilege.webp', 'Un compte privilégié est un compte bénéficiant de droits d’accès étendus permettant à des utilisateurs malveillants de porter plus facilement ou plus gravement atteinte à la sécurité ou au fonctionnement du SIIV. Les comptes privilégiés sont par exemple des comptes d’administrateurs ou des comptes d’utilisateurs disposant de droits à fort impact métier dans une application.', 7),
(32, 'Access Control List (ACL)', 'https://tse3.mm.bing.net/th?id=OIP.c1SEffZq7PJmuVYUkC95oQHaHa&pid=Api&P=0&h=180', 'Ensemble des règles et instructions données à un système d’exploitation pour lui permettre de gérer les besoins d’accès des utilisateurs ou des groupes utilisateurs. Grâce à l’ACL, le système d’exploitation sait s’il doit accorder ou non la permission d’accès à un fichier ou à un dossier à tel ou tel utilisateur. Cela s\'applique également au pare-feu.', 7),
(33, 'Autorité de certification (Certificate Authority)', 'https://tse1.mm.bing.net/th?id=OIP.Hm9DCEPuVltJVWKG2iUjUgHaE8&pid=Api&P=0&h=180', 'Tiers de confiance indépendant en charge de la vérification de l’identité́ d’une personne ou d’une entité́ et habilité à délivrer un certificat électronique.', 8),
(34, 'Certificat électronique ou (Certificate)', 'https://tse3.mm.bing.net/th?id=OIP.OlQXP5lZPpXzL6yyByrmKgHaD6&pid=Api&P=0&h=180', 'Ensemble de données permettant de vérifier et d’attester l’identité d’une personne ou d’une entité. Le certificat électronique est délivré par une autorité de certification (voir autorité de certification).', 8),
(35, 'Cybercriminalité', 'https://tse4.mm.bing.net/th?id=OIP.2XKbw_vqKdNKm88j0eVjCAFCDB&pid=Api&P=0&h=180', 'Actes contrevenants aux traités internationaux ou aux lois nationales, utilisant les réseaux ou les systèmes d’information comme moyens de réalisation d’un délit ou d’un crime, ou les ayant pour cible.', 9),
(36, 'Mailbomb', 'https://tse3.mm.bing.net/th?id=OIP.orApnec8RwTPV6UJvHVK4wHaD5&pid=Api&P=0&h=180', 'E-mails envoyés en masse vers un système unique ou une personne unique dans l\'intention de Crasher la machine du destinataire. Le Mailbombing est très souvent considéré comme scandaleux.', 9),
(37, 'Cyberdéfense', 'https://tse4.mm.bing.net/th?id=OIP.shIjsnLS6A1CnepDl1rqEgHaEK&pid=Api&P=0&h=180', 'Ensemble des mesures techniques et non techniques permettant à un État de défendre dans le cyberespace les systèmes d’information jugés essentiels.', 10),
(38, 'Cybersécurité', 'https://tse3.mm.bing.net/th?id=OIP.AtlBysN8Ik1d-PqUoelatwHaEO&pid=Api&P=0&h=180', 'État recherché pour un système d’information lui permettant de résister à des événements issus du cyberespace susceptibles de compromettre la disponibilité, l’intégrité ou la confidentialité des données stockées, traitées ou transmises et des services connexes que ces systèmes offrent ou qu’ils rendent accessibles. \r\nLa cybersécurité fait appel à des techniques de sécurité des systèmes d’information et s’appuie sur la lutte contre la cybercriminalité et sur la mise en place d’une cyberdéfense.', 9),
(39, 'Bug Bounty ', 'https://tse2.mm.bing.net/th?id=OIP.8qwYVE0mzmwtq8i0Ca1idgHaEs&pid=Api&P=0&h=180', 'Méthode de détection des failles de sécurité́ d’un système récompensant la personne ou le groupe de personnes à l’origine de la découverte.', 10),
(40, 'CERT (Computer Emergency Response Team)                     ', 'https://tse4.mm.bing.net/th?id=OIP.AoRK2SBjx7Ct_Xkk_a7CFQHaEK&pid=Api&P=0&h=180', 'Organisme national ou indépendant chargé de veiller, d’alerter et d’assister les entreprises ou les administrations en cas d’attaques informatiques. Les CERT peuvent également être appelés CSIRT (Computer Security Incident Response Team). Dans le cas de la France, les CSIRT homologués sont répertoriés sur le site www.cert. [ssi.gouv.fr](http://ssi.gouv.fr).', 10),
(41, 'MITRE', 'https://tse1.mm.bing.net/th?id=OIP.CcUAch5FSfdO31ZZa5zUugHaEK&pid=Api&P=0&h=180', 'est une [organisation à but non lucratif](https://fr.wikipedia.org/wiki/Association_%C3%A0_but_non_lucratif \"Association à but non lucratif\") américaine dont l\'objectif est de travailler pour l\'intérêt public. Ses domaines d\'intervention sont l\'[ingénierie des systèmes](https://fr.wikipedia.org/wiki/Ing%C3%A9nierie_des_syst%C3%A8mes \"Ingénierie des systèmes\"), la [technologie de l\'information](https://fr.wikipedia.org/wiki/Technologie_de_l%27information \"Technologie de l\'information\"), les concepts opérationnels, et la modernisation des entreprises.', 11),
(42, 'ATT&CK ', 'https://tse1.mm.bing.net/th?id=OIP.RHrarFQdX5dxwquXutZcewHaDw&pid=Api&P=0&h=180', 'ATT&CK (pour Adversarial Tactics, Techniques, and Common Knowledge) est une base de connaissance aidant a modeler les [tactiques et techniques](https://fr.wikipedia.org/wiki/Tactiques,_techniques_et_proc%C3%A9dures \"Tactiques, techniques et procédures\") utilisées par les cyberadversaires, ainsi qu\'a comprendre comment les détecter et les stopper[1](https://fr.wikipedia.org/wiki/ATT%26CK#cite_note-1). Cette base de connaissance classifie et décrit les [cyberattaques](https://fr.wikipedia.org/wiki/Cyberattaque \"Cyberattaque\") et les intrusions. Elle est créé et publiée par la [société à but non lucratif](https://fr.wikipedia.org/wiki/Personnalit%C3%A9_juridique \"Personnalité juridique\") [MITRE](https://fr.wikipedia.org/wiki/MITRE \"MITRE\") en 2013[2](https://fr.wikipedia.org/wiki/ATT%26CK#cite_note-2).', 11),
(43, 'Agence Nationale pour la Sécurité des Systèmes d\'Information', 'https://cybersecuritymonth.eu/about-ecsm/partners/agence-nationale-de-la-securite-des-systemes-dinformation/view/++widget++form.widgets.logo/@@download/20150626_logo_anssi_v3a.png', 'Créée par décret en juillet 2009, l’Agence nationale de la sécurité des systèmes d’information est un service à compétence nationale rattaché au Secrétaire général de la défense et de la sécurité nationale (SGDSN). L’ANSSI a pour missions de proposer les règles à appliquer pour la protection des systèmes d’information de l’État et des Opérateurs d’importance vitale, et de vérifier l’application des mesures adoptées. Elle assure également un service de veille, de détection, d’alerte et de réaction aux attaques informatiques.', 11),
(44, 'Canular (Hoax)', 'https://tse2.mm.bing.net/th?id=OIP.x-R4lFpPG2KOthuHevqWIgHaEM&pid=Api&P=0&h=180', 'Information vraie ou fausse, souvent transmise par messagerie électronique ou dans un forum, et incitant les destinataires à effectuer des opérations ou à prendre des initiatives, souvent dommageables.\r\nRemarques : Il peut s’agir d’une fausse alerte aux virus,de chaîne de solidarité, pétitions, promesse de cadeaux, etc. Quelques canulars fréquents sont répertoriés sur des sites dédiés comme « Hoaxbuster » ou « Hoaxkiller ».\r\n', 12),
(45, 'Accaparement de noms de domaine (Cybersquatting)', 'https://tse1.mm.bing.net/th?id=OIP.rgX3X7f7_zIJyrvsPBh5aQHaE9&pid=Api&P=0&h=180', 'Action malveillante qui consiste à faire enregistrer un nom de domaine dans le seul but de bloquer toute attribution ultérieure de ce nom au profit de titulaires plus naturels ou légitimes.\r\nRemarques : L’objectif est souvent d’obtenir un avantage financier en échange de la rétrocession du nom ainsi détourné. Cette pratique est particulièrement fréquente pour certains noms de domaine comme .net, .com, ou .org.\r\n', 12),
(46, 'Code malveillant, logiciel malveillant (Malware)', 'https://tse2.mm.bing.net/th?id=OIP.gNZVkj7lis3MfkH8FDb_jgHaEe&pid=Api&P=0&h=180', 'Tout programme développé dans le but de nuire à ou au moyen d’un système informatique ou d’un réseau.\r\nRemarques : Les virus ou les vers sont deux types de codes malveillants connus.\r\n', 13),
(47, 'Cheval de Troie (Trojan Horse)', 'https://tse4.mm.bing.net/th?id=OIP.SdqhoYy54_Qyi9BUHU6a-wHaE1&pid=Api&P=0&h=180', 'Programme donnant l’impression d’avoir une fonction utile, mais qui possède par ailleurs une fonction cachée et potentiellement malveillante.\r\n\r\nRemarques : La fonction cachée exploite parfois les autorisations légitimes d’une entité du système qui invoque ce programme. Elle peut par exemple permettre la collecte frauduleuse, la falsification ou la destruction de données.\r\n', 13),
(48, 'Capteur clavier, enregistreur de frappes (Keylogger)', 'https://tse4.mm.bing.net/th?id=OIP.FZVjG0neCkt3SGCmae_6XwHaDG&pid=Api&P=0&h=180', 'Logiciel ou matériel employé par un utilisateur malveillant pour capturer ce qu’une personne frappe au clavier.\r\n\r\nRemarques : Cette technique permet de voler efficacement les mots de passe, les données bancaires, les messages électroniques, etc.\r\n', 13),
(49, 'Fork Bomb', 'https://tse3.mm.bing.net/th?id=OIP.eXYMT3U7FUjKGtIwPdXphgAAAA&pid=Api&P=0&h=180', 'Aussi connu sous le nom de \"logic bomb\" (bombe logique), code pouvant être écrit en une ligne de code sur un système Unix; basé sur une duplication infinie de lui-même, il peut éventuellement \"exploser\" en détruisant toutes les entrées dans la table des processus et bloquant efficacement le système.', 13),
(50, 'Logic Bomb', 'https://tse3.mm.bing.net/th?id=OIP.3mvPiR3ZVDD6ZnyO221J0QHaE8&pid=Api&P=0&h=180', 'Aussi connu sous le nom de Fork Bomb, programme résidant sur un système informatique, qui, quand il est exécuté recherche une condition particulière ou un état particulier du système pour exécuter une action illicite une fois cette condition trouvée.', 13),
(51, 'Certification de sécurité', 'https://tse2.mm.bing.net/th?id=OIP.XRxmN074Z4Lxzlgg5HF6QQHaEF&pid=Api&P=0&h=180', 'Délivrée par l’ANSSI. Elle porte sur des produits de sécurité (matériels ou logiciels). Elle atteste de la conformité d’un produit de sécurité à un niveau de sécurité donné. Il s’agit d’une évaluation à l’état de l’art réalisée en fonction d’une cible de sécurité et d’un niveau de sécurité visé. \r\nElle est matérialisée par un rapport de certification et un certificat tous deux signés par le Directeur Général de l’Agence. Le catalogue des produits de sécurité certifiés, accompagnés de leur cible de sécurité et de leur rapport de certification est publié sur le site Web de l’Agence. On parle de certification « premier niveau » (CSPN) ou de certification « Critères Communs ». \r\nCette certification est délivrée par l’ANSSI sur la base des travaux dévaluation menés par un CESTI (Centre d’Evaluation de la Sécurité des Technologies de l’Information). \r\nLes CESTI sont des laboratoires accrédités par le COFRAC (Comité Français d’Accréditation) et agréés par l’ANSSI. Le catalogue des CESTI est publié sur le site Web de l’Agence. Au sein de l’ANSSI, c’est le Centre National de Certification de la Sous-direction Expertise qui remplit ces missions.', 14),
(52, 'Certification de Sécurité de Premier Niveau (CSPN)', 'https://tse3.mm.bing.net/th?id=OIP.8GpB04ehotIe5yProZcWFQHaE7&pid=Api&P=0&h=180', 'La Certification de Sécurité de Premier Niveau (CSPN) mise en place par l’ANSSI en 2008 consiste en des tests en « boîte noire » effectués en temps (2 mois) et charge (25 ou 35 hommes x jours) contraints. La CSPN est une alternative aux évaluations Critères Communs, dont le coût et la durée peuvent être un obstacle, lorsque le niveau de confiance visé est moins élevé.', 14),
(53, 'Cyberespace', 'https://uploads-ssl.webflow.com/601057763f823a0bf65a8071/612657a5f11a642a12ef28fe_Aperc%CC%A7u%20Cyberespace.jpg', 'Espace de communication constitué par l’interconnexion mondiale d’équipements de traitement automatisé de données numériques.', 15),
(54, 'Darkweb', 'https://tse3.mm.bing.net/th?id=OIP.CO1C1uLxwU4C3ZBRanhq8AHaDf&pid=Api&P=0&h=180', 'Le Dark Web, encore connu sous le nom de web clandestin, contient des contenus cachés et en grande partie illicites que l’on trouve uniquement sur le Darknet. Mais malgré son appellation “dark”, tous les contenus ne sont pas liés au cyber-crime.\r\n\r\nÀ l’origine, le projet Tor a été créé par les laboratoires de la US Navy pour garantir la confidentialité de leurs échanges. Aujourd’hui, Tor permet de contourner la censure et de favoriser la liberté d’expression des dissidents et des réfugiés politiques. Le réseau Tor est toutefois un réseau qui n’est pas parfaitement anonyme. En effet, certains agents du FBI ont déjà réussi à remonter la chaine pour retrouver des personnes qui avaient utilisé le réseau Tor. Il faut donc coupler ça avec un autre logiciel (comme par exemple un VPN) pour devenir 100% anonyme sur le darkweb.\r\n\r\nLe Dark Web est-il légal ?\r\n\r\nSi le Dark Web est souvent un lieu mystérieux qui est associé aux activités illicites et aux cyber-crimes, naviguer sur ce réseau n’est pourtant pas illégal. Certains journalistes et dissidents politiques s’y rendent pour communiquer et informer sans mettre en danger leur sécurité. Étant donné que le web profond fonctionne sur un protocole de communication différent, il renforce considérablement l’anonymat. C’est pour cette raison que de nombreux internautes souhaitant préserver leur identité se tourne vers ce réseau.\r\n\r\nCela dit, cet anonymat est à double tranchant. En effet, les personnes malintentionnées se sentiront forcément plus protégées en naviguant sur le Dark Web et elles seront plus à même de se livrer à des activités illégales. Il est vrai qu’on y trouve davantage de plateformes et de sites illégaux que sur l’Internet que nous connaissons.\r\n', 15),
(55, 'Darknet', 'https://tse2.mm.bing.net/th?id=OIP.0kxj2RSCU4TOESxoq4qcJQHaJN&pid=Api&P=0&h=180', 'Le Darknet est un ensemble de sous-réseaux d’internet qui ne sont pas accessibles via les moteurs de recherches classiques mais à l’aide de techniques spécifiques.\r\n\r\nIl existe plusieurs outils permettant d’y accéder comme Freenet, I2P ou encore Tor, le réseau Darknet le plus connu. Tor signifie “The Onion Router” ou le routeur oignon en référence à ses couches de protection. Il donne accès à des services cachés dont une partie du Dark Web, c’est pourquoi on l’associe souvent au Dark Web.\r\n', 15);

-- --------------------------------------------------------

--
-- Structure de la table `module`
--

DROP TABLE IF EXISTS `module`;
CREATE TABLE IF NOT EXISTS `module` (
  `mod_id` int NOT NULL AUTO_INCREMENT,
  `mod_titre` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mod_image` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`mod_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `module`
--

INSERT INTO `module` (`mod_id`, `mod_titre`, `mod_image`) VALUES
(1, 'Sécurité des Systèmes et Réseaux', 'https://s3.eu-west-3.amazonaws.com/actinbusiness.com/wp-content/uploads/2021/08/05093715/securite-reseau-informatique.jpg'),
(2, 'Cryptographie et Sécurité des Données', 'https://cdn.next.ink/inpactv7/data-next/images/bd/wide-linked-media/3086.jpg'),
(3, 'Authentification et Contrôle d\'Accès', 'https://www.2n.com/en_GB/documents/22902/10493542/Access+Commander+3.1+%28news%29_1200x628.jpeg/9a63cd96-c282-4aae-aa56-e814feb9897f?t=1713862189901'),
(4, 'Cybercriminalité et Cyberdéfense', 'https://media.xpair.com/redac/gtb/cybersecurite.png'),
(5, 'Ingénierie Sociale et Manipulation', 'https://www.ulaval.ca/sites/default/files/Cybersecurite/Video_ingenierie_sociale.jpg'),
(6, 'Malwares et Programmes Malveillants', 'https://www.pandasecurity.com/fr/mediacenter/src/uploads/2019/12/pandasecurity-virus.jpg'),
(7, 'Certifications et Conformité', 'https://lh4.googleusercontent.com/proxy/59SLGxRsKgLb8Uj_EZfB3eQ9KL0R9-myxKqePcGKbcrI3OZjgkBL5_s8vYpZQTSK8jVgboKKx6980oPA9J4ewnMuWd8iipFQ249XDfasig'),
(8, 'Environnements Numériques et Concepts', 'https://www.kaspersky.fr/content/fr-fr/images/repository/isc/2020/deep-web-cover.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `progression`
--

DROP TABLE IF EXISTS `progression`;
CREATE TABLE IF NOT EXISTS `progression` (
  `prog_id` int NOT NULL AUTO_INCREMENT,
  `prog_pourcentage` int NOT NULL,
  `prog_dateAcces` datetime NOT NULL,
  `uti_id` int DEFAULT NULL,
  `cours_id` int DEFAULT NULL,
  PRIMARY KEY (`prog_id`),
  KEY `uti_id` (`uti_id`),
  KEY `cours_id` (`cours_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déclencheurs `progression`
--
DROP TRIGGER IF EXISTS `before_update_progression`;
DELIMITER $$
CREATE TRIGGER `before_update_progression` BEFORE UPDATE ON `progression` FOR EACH ROW BEGIN
    IF NEW.prog_pourcentage > 100 THEN
        SET NEW.prog_pourcentage = 100;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `theme`
--

DROP TABLE IF EXISTS `theme`;
CREATE TABLE IF NOT EXISTS `theme` (
  `theme_id` int NOT NULL AUTO_INCREMENT,
  `theme_nom` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mod_id` int DEFAULT NULL,
  PRIMARY KEY (`theme_id`),
  KEY `mod_id` (`mod_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `theme`
--

INSERT INTO `theme` (`theme_id`, `theme_nom`, `mod_id`) VALUES
(1, 'Attaques Réseau et Exploits', 1),
(2, 'Vulnérabilités et Défauts', 1),
(3, 'Sécurité Réseau', 1),
(4, 'Cryptographie', 2),
(5, 'Sécurité des Données et Confid', 2),
(6, 'Authentification', 3),
(7, 'Gestion des Comptes et Accès', 3),
(8, 'Certificats et Autorités de Ce', 3),
(9, 'Cybercriminalité', 4),
(10, 'Défense des Systèmes', 4),
(11, 'Organismes de Régulation et No', 4),
(12, 'Ingénierie Sociale', 5),
(13, 'Malware', 6),
(14, 'Certifications de Sécurité', 7),
(15, 'Environnements Numériques', 8);

--
-- Déclencheurs `theme`
--
DROP TRIGGER IF EXISTS `before_delete_theme`;
DELIMITER $$
CREATE TRIGGER `before_delete_theme` BEFORE DELETE ON `theme` FOR EACH ROW BEGIN
    DELETE FROM Cours WHERE theme_id = OLD.theme_id;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `uti_id` int NOT NULL AUTO_INCREMENT,
  `uti_nom` varchar(50) NOT NULL,
  `uti_prenom` varchar(50) NOT NULL,
  `uti_login` varchar(50) NOT NULL,
  `uti_motPasse` varchar(255) NOT NULL,
  `uti_role` enum('apprenant','formateur','admin') NOT NULL,
  PRIMARY KEY (`uti_id`),
  UNIQUE KEY `uti_login` (`uti_login`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`uti_id`, `uti_nom`, `uti_prenom`, `uti_login`, `uti_motPasse`, `uti_role`) VALUES
(30, 'DEVARGAS', 'Guillaume', 'Gdevargas', 'devargas.g3', 'admin'),
(31, 'BENMAMAS', 'Jugurta', 'Jbenmamas', 'benmamas.j2', 'apprenant'),
(32, 'BEN', 'Juju', 'Jben', 'ben.j2', 'formateur');

--
-- Déclencheurs `utilisateur`
--
DROP TRIGGER IF EXISTS `before_insert_utilisateur`;
DELIMITER $$
CREATE TRIGGER `before_insert_utilisateur` BEFORE INSERT ON `utilisateur` FOR EACH ROW BEGIN

SET NEW.uti_nom = UPPER(NEW.uti_nom);
    SET NEW.uti_prenom = CONCAT(UPPER(LEFT(NEW.uti_prenom, 1)), LOWER(SUBSTRING(NEW.uti_prenom, 2)));

SET NEW.uti_login = CONCAT(UPPER(LEFT(NEW.uti_prenom, 1)), LOWER(NEW.uti_nom));

SET NEW.uti_motPasse = CONCAT(LOWER(NEW.uti_nom),'.', LOWER(LEFT(NEW.uti_prenom, 1)),ROUND(RAND()*4)+1);

END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `before_update_utilisateur`;
DELIMITER $$
CREATE TRIGGER `before_update_utilisateur` BEFORE UPDATE ON `utilisateur` FOR EACH ROW BEGIN
    IF OLD.uti_nom != NEW.uti_nom OR OLD.uti_prenom != NEW.uti_prenom THEN
    SET NEW.uti_nom = UPPER(NEW.uti_nom);
     SET NEW.uti_prenom = CONCAT(UPPER(LEFT(NEW.uti_prenom, 1)), LOWER(SUBSTRING(NEW.uti_prenom, 2)));

    
    
        SET NEW.uti_login = CONCAT(UPPER(LEFT(NEW.uti_prenom, 1)), LOWER(NEW.uti_nom));
        SET NEW.uti_motPasse = CONCAT(LOWER(NEW.uti_nom), '.', LOWER(LEFT(NEW.uti_prenom, 1)), ROUND(RAND() * 4) + 1);
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `valider`
--

DROP TABLE IF EXISTS `valider`;
CREATE TABLE IF NOT EXISTS `valider` (
  `val_id` int NOT NULL AUTO_INCREMENT,
  `compris_OuiNon` tinyint(1) NOT NULL,
  `uti_id` int DEFAULT NULL,
  `cours_id` int DEFAULT NULL,
  PRIMARY KEY (`val_id`),
  KEY `uti_id` (`uti_id`),
  KEY `cours_id` (`cours_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déclencheurs `valider`
--
DROP TRIGGER IF EXISTS `after_update_valider`;
DELIMITER $$
CREATE TRIGGER `after_update_valider` AFTER UPDATE ON `valider` FOR EACH ROW BEGIN
    IF NEW.compris_OuiNon = TRUE THEN
        UPDATE Progression
        SET prog_pourcentage = prog_pourcentage + (100 / (SELECT COUNT(*) FROM Cours WHERE theme_id = (SELECT theme_id FROM Cours WHERE cours_id = NEW.cours_id)))
        WHERE uti_id = NEW.uti_id AND cours_id = NEW.cours_id;
    END IF;
END
$$
DELIMITER ;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `cours`
--
ALTER TABLE `cours`
  ADD CONSTRAINT `cours_ibfk_1` FOREIGN KEY (`theme_id`) REFERENCES `theme` (`theme_id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `progression`
--
ALTER TABLE `progression`
  ADD CONSTRAINT `progression_ibfk_1` FOREIGN KEY (`uti_id`) REFERENCES `utilisateur` (`uti_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `progression_ibfk_2` FOREIGN KEY (`cours_id`) REFERENCES `cours` (`cours_id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `theme`
--
ALTER TABLE `theme`
  ADD CONSTRAINT `theme_ibfk_1` FOREIGN KEY (`mod_id`) REFERENCES `module` (`mod_id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `valider`
--
ALTER TABLE `valider`
  ADD CONSTRAINT `valider_ibfk_1` FOREIGN KEY (`uti_id`) REFERENCES `utilisateur` (`uti_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `valider_ibfk_2` FOREIGN KEY (`cours_id`) REFERENCES `cours` (`cours_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
