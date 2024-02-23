/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--Ajout des valeurs pour les catégories
EXEC SP_Categorie_Insert 'Accessoires';
EXEC SP_Categorie_Insert 'Alimentaire';
EXEC SP_Categorie_Insert 'Thérapeutique';
GO

--Ajout des valeurs pour les Produits
EXEC SP_Produit_Insert 'Miel édition Summer',
                        'Découvrez notre Miel Summer Edition, un trésor naturel à l''état pur.  Chaque goutte de ce délice provient de nos ruchers locaux,   récoltée à la main, filtrée et maturée avec soin. Notre miel est naturel,  sans sucre ajouté ni aucun autre produit altérant sa pureté.  Sa saveur estivale, riche et unique, évoque les chaudes journées d''été.   Sa texture particulière en fait l''accompagnement parfait pour vos petits déjeuners,   vos tasses de thé (ne dépassez pas 40°C) et vos plateaux de fromage.  En privilégiant notre miel, vous encouragez la production locale   et soutenez les abeilles ainsi que la biodiversité.  Chaque pot contient 250g de ce délice, une véritable expérience gourmande.  Millésime 2022, goûtez l''année en chaque cuillère.',
                        8.50,
                        'A',
                        'Alimentaire';
EXEC SP_Produit_Insert 'Miel édition Spring','Délicatement récolté à la main dans nos ruchers en pleine nature,   Notre miel Spring Edition vous permet de vivre une expérience printanière exceptionnelle   grâce à sa texture onctueuse et son goût authentique qui réjouiront vos sens.  Disponible en pots de 250g, il et soigneusement récolté à la main dans nos ruchers en pleine nature.  Sa texture onctueuse et son goût naturel raviront vos papilles,   sans sucre ajouté ni altération par d''autres produits.',8.50,'A','Alimentaire';
EXEC SP_Produit_Insert 'Miel édition Spring Break','Découvrez notre Miel Summer Edition, un trésor naturel à l''état pur.  Chaque goutte de ce délice provient de nos ruchers locaux, récoltée à la main,   filtrée et maturée avec soin. Notre miel est naturel,   sans sucre ajouté ni aucun autre produit altérant sa pureté.  Sa saveur estivale, riche et unique, évoque les chaudes journées d''été.  Sa texture particulière en fait l''accompagnement parfait pour vos petits déjeuners,   vos tasses de thé (ne dépassez pas 40°C) et vos plateaux de fromage.  En privilégiant notre miel, vous encouragez la production locale   et soutenez les abeilles ainsi que la biodiversité.  Chaque pot contient 250g de ce délice, une véritable expérience gourmande.   Millésime 2022, goûtez l''année en chaque cuillère.',8.50,'A','Alimentaire';
EXEC SP_Produit_Insert 'Bières Kiss Bee','La bière Kiss Bee est une IPA blonde richement houblonnée,  avec un degré d''alcool de 7%.',23.93,'D','Alimentaire';
EXEC SP_Produit_Insert 'Miel à la Propolis','Combinant miel de qualité supérieure et 5% de teinture mère de propolis,   ce produit unique offre des bienfaits exceptionnels,   associant les propriétés antimicrobiennes et antioxydantes de la propolis   aux qualités naturelles du miel. Veuillez noter la présence d''alcool,   rendant ce produit déconseillé aux personnes allergiques aux produits de la ruche,   aux femmes enceintes et aux enfants de moins de 3 ans.  Pour ceux en mesure de le consommer en toute sécurité,   ce miel à la propolis vous invite à renforcer votre système immunitaire   et affronter le froid avec délice.  un remède prisé en hiver pour renforcer l''immunité.',18.00,'A','Thérapeutique';
EXEC SP_Produit_Insert 'Pack découverte','Conçu pour être une trousse de premiers soins pour toute la famille,   notre pack comprend nos 4 miels thérapeutiques :   Le propolis – refroidissement Le charbon actif –   digestion Le CBD équilibre L’Acerola – immunité.  Ces miels sont formulés pour convenir à toute la famille,   y compris aux enfants âgés d''au moins un an.  Chaque miel offre des avantages spécifiques, du renforcement de l''immunité  à l''amélioration de la digestion.',65.00,'A','Thérapeutique';
EXEC SP_Produit_Insert 'Miel CBD','Dans ce pot de 140g, découvrez un miel vivant aux propriétés apaisantes   et relaxantes, travaillé à froid pour préserver toutes ses vertus,   associé au CBD pour une synergie exceptionnelle équivalente à une huile sublinguale   contenant 10% de CBD.  Son travail à froid permet de conserver toutes ses vertus et principes actifs  (enzymes et lysosomes), et joue un rôle de catalyseur pour les propriétés du CBD.',18.00,'A','Thérapeutique';
EXEC SP_Produit_Insert 'Miel Acerola Hibiscus – Vitamine C','Découvrez un Miel vivant aux vertus incroyables mais vrai.   Ce miel conditionné en pots de 140g, est le résultat d''un processus de travail   à froid minutieux qui préserve toutes ses qualités naturelles,   notamment ses enzymes et lysosomes. Mais ce n''est pas tout.  Grâce à sa synergie unique avec l''acerola et l''hibiscus,   il devient un allié incontournable pour votre bien-être.   La combinaison de ces ingrédients vous garantit des apports quotidiens en vitamine C,   renforce votre système immunitaire, soutient votre vitalité, et agit comme un puissant antioxydant.  Avec seulement 2 cuillères à café par jour, vous obtenez votre dose quotidienne de vitamine C,   soit 125mg. Une façon délicieuse et naturelle de prendre soin de votre santé.',18.00,'A','Thérapeutique';
EXEC SP_Produit_Insert 'Miel Charbon Actif Végétal','Plus qu''un simple miel, découvrez cette pépite dans 140g de miel vivant et énergétique.   Il deviendra un véritable allié de votre bien-être. Grâce à un processus de travail à froid méticuleux,   il conserve toutes ses vertus naturelles, y compris ses précieuses enzymes et lysosomes.   Mais ce miel va encore plus loin. Il joue un rôle catalyseur pour les propriétés exceptionnelles   du Charbon Actif Végétal et permet un nettoyage en profondeur de votre organisme,   débarrassant votre corps des excès du quotidien : toxines, produits chimiques,   métaux lourds, et bien plus encore. Cette combinaison agit efficacement sur des troubles  digestifs fréquents tels que les ballonnements, la diarrhée, et les brûlures d''estomac.  Offrez à votre corps un purifiant naturel, à la fois délicieux et bienfaisant.  Il devient un véritable allié de votre bien-être. Grâce à un processus de travail à froid méticuleux,  il conserve toutes ses vertus naturelles, y compris ses précieuses enzymes et lysosomes.  Mais ce miel va encore plus loin.',18.00,'A','Thérapeutique';
EXEC SP_Produit_Insert 'Pièges à guêpes/frelons',NULL,6.66,'D','Accessoires';
GO

--Ajout des valeurs pour les Medias
DECLARE @Id_Produit INT;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Bières Kiss Bee';
EXEC SP_Media_Insert 'BiereBee.jpg','assets/images/BiereBee.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel édition Spring Break';
EXEC SP_Media_Insert 'MielBreack.jpg','assets/images/MielBreack.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel édition Summer';
EXEC SP_Media_Insert 'MielSummer.jpg','assets/images/MielSummer.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel édition Spring';
EXEC SP_Media_Insert 'MielSpring.jpg','assets/images/MielSpring.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel à la Propolis';
EXEC SP_Media_Insert 'MielPropolis.jpg','assets/images/MielPropolis.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel Acerola Hibiscus – Vitamine C';
EXEC SP_Media_Insert 'MielAcerola.jpg','assets/images/MielAcerola.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel Charbon Actif Végétal';
EXEC SP_Media_Insert 'MielCharbon.jpg','assets/images/MielCharbon.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Miel CBD';
EXEC SP_Media_Insert 'MielCbd.jpg','assets/images/MielCbd.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Pack découverte';
EXEC SP_Media_Insert 'Pack.jpg','assets/images/Pack.jpg',@Id_Produit;
SELECT @Id_Produit = Id_Produit FROM Produit WHERE Nom = 'Pièges à guêpes/frelons';
EXEC SP_Media_Insert 'Pieges.png','assets/images/Pieges.png',@Id_Produit;
GO
 