-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: inkwatchdb
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_brands`
--

DROP TABLE IF EXISTS `tbl_brands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_brands` (
  `brand_id` int NOT NULL AUTO_INCREMENT,
  `brand_name` varchar(100) NOT NULL,
  `brand_logo` mediumblob,
  PRIMARY KEY (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_brands`
--

LOCK TABLES `tbl_brands` WRITE;
/*!40000 ALTER TABLE `tbl_brands` DISABLE KEYS */;
INSERT INTO `tbl_brands` VALUES (1,'HP',NULL),(2,'Canon',NULL),(3,'Epson',NULL),(7,'Brother',NULL),(8,'Samsung',NULL),(9,'Lexmark',NULL),(10,'Xerox',NULL),(11,'Ricoh',NULL),(12,'Dell',NULL),(13,'Kyocera',NULL),(14,'Sharp',NULL),(15,'OKI',NULL),(16,'Panasonic',NULL),(17,'Konica Minolta',NULL),(18,'Fujitsu',NULL),(19,'Toshiba',NULL),(20,'Zebra',NULL),(21,'Honeywell',NULL),(22,'Primera',NULL),(23,'Dymo',NULL),(24,'Seiko',NULL),(25,'Citizen',NULL),(26,'TSC',NULL),(27,'Intermec',NULL),(28,'SATO',NULL),(29,'Pantum',NULL),(30,'Lanier',NULL),(31,'Gestetner',NULL),(32,'Sindoh',NULL),(33,'Olivetti',NULL),(34,'Formax',NULL),(35,'Savin',NULL),(36,'UTAX',NULL),(37,'Develop',NULL),(38,'Infotec',NULL),(39,'Nashuatec',NULL),(42,'KINUCA',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\á\0\0\0\á\0\0\0	m\"H\0\0\0´PLTEÿÿÿ\0ˆ\Ì\0\0\0\0€\É\0…\Ë\0~\È\0ƒ\Ên­\Û\0\É\0„\Ë\Ğ\ã\ò\0|\È\ô\ô\ôüüü‘‘‘§§§\É\É\É\Ó\Ó\Óyyy111\â\ââ‡‡‡®®®QQQzzzŒ¼\á\ß\ì\ö\ï\öû\×\ç\ôooo\Ã\Ã\Ã\è\òù¢\È\æ¸\Õì¡¡¡µ\Ó\ë5•\ÑMÕ‡º\àAAAa§\Ø\Ç\Ş\ğy²\Ü\ì\ìì»»»aaa›\ÅåŠ»\áDš\Ó%%%;;;\Z\Z\Z˜˜˜LLLfff!!!^¥\Ø666ŒŒŒ]\İ(O\0\0\nzIDATxœ\íœg{\â¼†Á\rSŒ’\ĞbÀú¦\în6ÿÿ\ÍHr\ÃŠy\åœk\î/qÀ–\õH3$[I¡@AAAAAAAAAA\Ä5\èu+‹\Ñh´X\ô{ª\ë’5o9-š¦©Û€®³#ş0zT]¯lX<øU\İ.\Å†e›\å\Òä§«•t\İ\Ú‘i›ş¶«º–g\Ó]\ê\öu\Ë\ô=\ÕU=‹Å³Yş^\ì\Éå‹Ö…o\Ñ}‘\ÕÒ\ò\×\î\óiú€²9S]\í\ãYVO\ÖX\ÖHuÍcaX\ç\è\Ì\éOÕ¥y®¾\"x\ÎBuı¿£\ç\Û„n\Ìy6V\0cOU‹8Ä¤z©>F¹˜\ßd\ô²È’\Ñ\È\ë\ğ¿½\Äcb­|J\ô²\È$–\ó¨£lBTH,:ª\õ\ì\Ğ\ÏR “\è«”¤w\ö<fVIµ¤ş\Å\ã`s¢ZSŒ™µ@&1O†šqrr•ŠW\Ğ\Ç\Ğ=Õº¶Î¶\÷J\ÌË\Ñ\Ën¨c-UK”}\ât2\Õ|Lm¯a3#¸¼Z²#™\è\\+\ÛS-\á]\ÉH9y§™\Ï\×B£\ÚW­¯P\ĞM~\Z\æat6•\÷ı\ç\\<^tœ^¯\÷ø\Ø\í\öû•#\é3ºœG \Çqœ<Ko¾œız\Øz“Ñ¢Ò½üİ®\Ó\ë\ö#o;+}>û\ğ\ÊFı¼¦j”Ë†eY¶n\óÈ³‹şt^Z>x\Ó\Ü\ï\ö‰=•\Å\Ä\ÛşZ¢\"Ÿ¬(«l<¿•»\é\"e\Ùd\0¼\Îf\õ­2L«\È2ê³´œAg‡zªø%¾ü¶))Y˜\ê•\ğ¤j\ów\óø~>\êz™[\Å\çg©´\\Î˜¸\í\ö\ñk²\\–J\ó\Ï\é\ô\Ù\÷}xUš0 :W¬°0\ZM¼\Éd[,XP\ö»`†\Ãm+ ³šI60‡\É\ØœŞ£HĞ’\ê\÷†\Ø=\Âb\Êƒ¾\Ú?\ÅW{`8,¶³\å|\Ê,”Ç¨\éYUÜ‹z\Òb\ÊV\Äctt˜ù¼T‚\\Œ\0°dvS®\Æü¦¼c8º\â\'R&\Z\'/‚\îD›\ñ}¦\r…±\ñ’ÙŒ·—\ğ\Ö)¨Õ…Ã€qYh¯¬+\\>?Ch\Â0€ƒ>›ª¿\Ã	#–\Ù.x\ïCfu\Í\àªl*¨¸\Ï8jY|\äc!ù€Fƒ	\Ã\ÆQe„ı†‹\éi\Èp×«\Şu|‡u™::\rŸ²\èqø\ß}¾±Ÿ#ŒF‡\Ü+‰Ù¥Xa\ÜD\å\ÜV>`¢,A1™LpN€,`j ™@º\ÍX·M\Ãn“>SJm\ÅNSª‚\"”\Å\'ŸkŸ?úG}Fê¶”\Ïjş\ß\éÍ§\Óp‚\ók6l\à4FX\Û\îRn˜•\ÊfËƒ\ösŠ3qœ7|şGJ\öQ1!Yø\Ø,VŠ_j\ğ…†p’ªnI\n‰†™¦›¡\Í\è|yb¥xb…½\è\ã\à\Ğo¸\Õ<Ag\â\0\ÎUEªa®a‡±±ÁW¾VrÚ¦|}X\ğ\Í\è\âüFÌ»O\ó¦†C;X!ª´±ªpY˜ı#1x¼\ÕeİyÁ\'ÓD—\î»+ˆ³\á“\İ¼.¢=”#¶•‡|³+>\ó.\ÍDi\åšof”\È5\õY[\Õ\ê€k¾|2\ó\ğ\Ú\"²‚\Ê\õ\Ã=g›\õ¯€j\Æ\n\äZ^S\ÎI^/s’…@\öû\ö\0;F\Êy¼Fœ\æj_[–; T?\ÎO\ğ™ışROµ¦ÅŒ%Z\Ê\ß&\ée\ë§ùJBN?\ËT\Ì\ã^}¶\È\ÈnŸa\åg$Œ²\ÈJb^ÿf&³¥¢‘\ã?\í\ê¦\ï9\r\Ë\ÏcJ.ş\ËbQWıû;.ú#YF5G“\Ñ=,\ì\ö[EÕ¯|Á™ŸÛF5ûº¿gQ<+u?_s\íƒx\ö\É\Z\õ¢\ò7§±=M£mxªk|:^\ñ\Øa˜ş\ë?I¥d~ÿ\÷ù†m–r\ğ\èşlF%\İ\ÜÿO†K7\ç?\ä\ß} ¿ı´L\Ø\×Ó†»irÿo0\åq\á-§¾lÿ-û\ó‡\ÉO\ÜO\öÿf¾İ– ‚ ‚ ˆ\Âj¥ºŒ\Ú\ê\ò%‰3h\İ\Ê\ãzK\ï4\Æ\ÇZ|±n\İÖ‚›Z.üÜ·ÂŠ\ß›Wşº.¤\àF¢\õ\Z­Ö\×a\×\Zˆ{µ[P‰—w!²=h\Õ\ñ`Üº—ø7\íƒ\nY\âğ–•‡…×4Á¯\Ê;lH5š†\Ò\ØG\â“\á?ù6(2åµ \0¸V\È\íhxÄŠ\Ôò»¨D\á^VB\ã-\ÖdM-?hışF\á\r?ªK+¸\ô½\Ñ\ÃÏ¶üJûJWÈ›\ãePK	\ï\Ú\İ\î}Ü AX´§…\Ú\ÛJ~\Ék\Í\Ö\Z6;P¼+\òr;_\õ:k‡\÷zıKH8Ô‰B\Ğ\Ão\ò¦iON\ĞZT¨m\Òb\íê±œe4w\î\Ã*|/›²)c\n\åEBaK¶.V¬U(\Êø’\Ç\ï²j‡v‚\Ùo\ò\ÛW.‡)d}À[>¡\ğ5hIG¥\ÄC¡p\Ã;	…¿2¸\Âfx:\æHRa#LŠ‚–Ú¤I…\ë°\ÄH\ÎÚ¼¹™\ÂU\í¯x\\\áP\Û	‘-Z‚\0\Ê\×ş- \Z=TØ‚†Å«¸\ÂM\Ø\åx«\õ~…X\Ş\Çw\n‡a34´H\Æ@uPa»\à¼\à-\â\n\ïD»~\ävÀ\0?]‹\ï\Ä-¢\n1\Z\ÛRa¬\á˜ø\ßû¾ho»MšP1!¯~ø\ZFÈ½P§²b\ã\nƒ€`	Wü/@\Ó^ıLH\Ç\íS(¬6c\Í\ÌÛ£\r;2>\ö*\Ä\ö¹s\Éa´ÀTˆ&\Ûp’\n\ã­\Ç\âz5K~z%¯áŠ¿P\Ù\÷]…O\\a#\íC\n1\Ø	áˆšª›‰—ù\Éa”>b0\ï\ôa¼\èº\ï[¢k]Wƒ[t\ğÑ	…Â[¡\ğ\Ïq\n\Û\ØX\Øù©\n±”\'Q™\Èp\ÆZ´*„QxSøG\ô†DTv‹24†Gû¿x\å£PR!\ÉoP¸Š]¿\Æ:¦+ƒ\Ën^\ì(\Ä^¼R\Ã\É \Â@a\á/WD\á=]yæ‹¦E§iüdV\ï\'b\Ô\ÚHQÍ«I§	cc€5KUX®\ÑI4išB<	\òÿ»-ü¬U\ØL(lk± .H\ß\Æ\î\ØF3\ó-h¾5¿Ç\Â\Â?-Ÿ^\å\Õ+n¬©\n\ërx‹7iªB¸ÿ_~±9V\Â*C…X\É\èˆ\ß\Ò\Â\êaˆ¦¿‰†¯\Ë{‹ˆ‚ŸR¶…B\ğm\Ù\Îÿøˆ”ª0hˆd^¤*t\Ä\ğ^C94G®\nqş¨¹bZ\ó7¸M#\Z\ì\ÙfZ\äÀIS~Š‰\×\ã˜\ßş\'JJS\Ø	\Ó\ï%\ái\n1\à\'Ì ´Á\à-%#\n¡\Ó\âk>i\Õ>\Æ\Ğ$cy\Şk|^\Å\Õ\ŞÊ‹6˜ˆ)\nWrÒŠ³ M\ç\õ\Ø~L\á\Û\0\Ë4¡\ğ-\ì¸a\Ì?\â\nCŸ•\Ô\Ñ¢¾_…+haT\Ô\Şo\ğ\ä/\Í\à&M-˜°6\Ãš\äk(¢·dl\ä´;\Û\Ú	\n\äÔ¥\Âu´\ßn\â2vÃ‘«\áº\"†·›»ûÀ›\î8X:üœ±\Él§9\\¯ÛÛ‰®\ëŠtn\Å´\İL5ù)\Î8\ò}\Û\ËVj\Ö7w™\0…»#‡]\Ó»,†N-Z\ä¯!‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚øÿu\ñ\Ê\Ò\Ò\â\0\0\0\0IEND®B`‚'),(43,'KOMMMASD',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\á\0\0\0\á\0\0\0	m\"H\0\0\0´PLTEÿÿÿ\0ˆ\Ì\0\0\0\0€\É\0…\Ë\0~\È\0ƒ\Ên­\Û\0\É\0„\Ë\Ğ\ã\ò\0|\È\ô\ô\ôüüü‘‘‘§§§\É\É\É\Ó\Ó\Óyyy111\â\ââ‡‡‡®®®QQQzzzŒ¼\á\ß\ì\ö\ï\öû\×\ç\ôooo\Ã\Ã\Ã\è\òù¢\È\æ¸\Õì¡¡¡µ\Ó\ë5•\ÑMÕ‡º\àAAAa§\Ø\Ç\Ş\ğy²\Ü\ì\ìì»»»aaa›\ÅåŠ»\áDš\Ó%%%;;;\Z\Z\Z˜˜˜LLLfff!!!^¥\Ø666ŒŒŒ]\İ(O\0\0\nzIDATxœ\íœg{\â¼†Á\rSŒ’\ĞbÀú¦\în6ÿÿ\ÍHr\ÃŠy\åœk\î/qÀ–\õH3$[I¡@AAAAAAAAAA\Ä5\èu+‹\Ñh´X\ô{ª\ë’5o9-š¦©Û€®³#ş0zT]¯lX<øU\İ.\Å†e›\å\Òä§«•t\İ\Ú‘i›ş¶«º–g\Ó]\ê\öu\Ë\ô=\ÕU=‹Å³Yş^\ì\Éå‹Ö…o\Ñ}‘\ÕÒ\ò\×\î\óiú€²9S]\í\ãYVO\ÖX\ÖHuÍcaX\ç\è\Ì\éOÕ¥y®¾\"x\ÎBuı¿£\ç\Û„n\Ìy6V\0cOU‹8Ä¤z©>F¹˜\ßd\ô²È’\Ñ\È\ë\ğ¿½\Äcb­|J\ô²\È$–\ó¨£lBTH,:ª\õ\ì\Ğ\ÏR “\è«”¤w\ö<fVIµ¤ş\Å\ã`s¢ZSŒ™µ@&1O†šqrr•ŠW\Ğ\Ç\Ğ=Õº¶Î¶\÷J\ÌË\Ñ\Ën¨c-UK”}\ât2\Õ|Lm¯a3#¸¼Z²#™\è\\+\ÛS-\á]\ÉH9y§™\Ï\×B£\ÚW­¯P\ĞM~\Z\æat6•\÷ı\ç\\<^tœ^¯\÷ø\Ø\í\öû•#\é3ºœG \Çqœ<Ko¾œız\Øz“Ñ¢Ò½üİ®\Ó\ë\ö#o;+}>û\ğ\ÊFı¼¦j”Ë†eY¶n\óÈ³‹şt^Z>x\Ó\Ü\ï\ö‰=•\Å\Ä\ÛşZ¢\"Ÿ¬(«l<¿•»\é\"e\Ùd\0¼\Îf\õ­2L«\È2ê³´œAg‡zªø%¾ü¶))Y˜\ê•\ğ¤j\ów\óø~>\êz™[\Å\çg©´\\Î˜¸\í\ö\ñk²\\–J\ó\Ï\é\ô\Ù\÷}xUš0 :W¬°0\ZM¼\Éd[,XP\ö»`†\Ãm+ ³šI60‡\É\ØœŞ£HĞ’\ê\÷†\Ø=\Âb\Êƒ¾\Ú?\ÅW{`8,¶³\å|\Ê,”Ç¨\éYUÜ‹z\Òb\ÊV\Äctt˜ù¼T‚\\Œ\0°dvS®\Æü¦¼c8º\â\'R&\Z\'/‚\îD›\ñ}¦\r…±\ñ’ÙŒ·—\ğ\Ö)¨Õ…Ã€qYh¯¬+\\>?Ch\Â0€ƒ>›ª¿\Ã	#–\Ù.x\ïCfu\Í\àªl*¨¸\Ï8jY|\äc!ù€Fƒ	\Ã\ÆQe„ı†‹\éi\Èp×«\Şu|‡u™::\rŸ²\èqø\ß}¾±Ÿ#ŒF‡\Ü+‰Ù¥Xa\ÜD\å\ÜV>`¢,A1™LpN€,`j ™@º\ÍX·M\Ãn“>SJm\ÅNSª‚\"”\Å\'ŸkŸ?úG}Fê¶”\Ïjş\ß\éÍ§\Óp‚\ók6l\à4FX\Û\îRn˜•\ÊfËƒ\ösŠ3qœ7|şGJ\öQ1!Yø\Ø,VŠ_j\ğ…†p’ªnI\n‰†™¦›¡\Í\è|yb¥xb…½\è\ã\à\Ğo¸\Õ<Ag\â\0\ÎUEªa®a‡±±ÁW¾VrÚ¦|}X\ğ\Í\è\âüFÌ»O\ó¦†C;X!ª´±ªpY˜ı#1x¼\ÕeİyÁ\'ÓD—\î»+ˆ³\á“\İ¼.¢=”#¶•‡|³+>\ó.\ÍDi\åšof”\È5\õY[\Õ\ê€k¾|2\ó\ğ\Ú\"²‚\Ê\õ\Ã=g›\õ¯€j\Æ\n\äZ^S\ÎI^/s’…@\öû\ö\0;F\Êy¼Fœ\æj_[–; T?\ÎO\ğ™ışROµ¦ÅŒ%Z\Ê\ß&\ée\ë§ùJBN?\ËT\Ì\ã^}¶\È\ÈnŸa\åg$Œ²\ÈJb^ÿf&³¥¢‘\ã?\í\ê¦\ï9\r\Ë\ÏcJ.ş\ËbQWıû;.ú#YF5G“\Ñ=,\ì\ö[EÕ¯|Á™ŸÛF5ûº¿gQ<+u?_s\íƒx\ö\É\Z\õ¢\ò7§±=M£mxªk|:^\ñ\Øa˜ş\ë?I¥d~ÿ\÷ù†m–r\ğ\èşlF%\İ\ÜÿO†K7\ç?\ä\ß} ¿ı´L\Ø\×Ó†»irÿo0\åq\á-§¾lÿ-û\ó‡\ÉO\ÜO\öÿf¾İ– ‚ ‚ ˆ\Âj¥ºŒ\Ú\ê\ò%‰3h\İ\Ê\ãzK\ï4\Æ\ÇZ|±n\İÖ‚›Z.üÜ·ÂŠ\ß›Wşº.¤\àF¢\õ\Z­Ö\×a\×\Zˆ{µ[P‰—w!²=h\Õ\ñ`Üº—ø7\íƒ\nY\âğ–•‡…×4Á¯\Ê;lH5š†\Ò\ØG\â“\á?ù6(2åµ \0¸V\È\íhxÄŠ\Ôò»¨D\á^VB\ã-\ÖdM-?hışF\á\r?ªK+¸\ô½\Ñ\ÃÏ¶üJûJWÈ›\ãePK	\ï\Ú\İ\î}Ü AX´§…\Ú\ÛJ~\Ék\Í\Ö\Z6;P¼+\òr;_\õ:k‡\÷zıKH8Ô‰B\Ğ\Ão\ò¦iON\ĞZT¨m\Òb\íê±œe4w\î\Ã*|/›²)c\n\åEBaK¶.V¬U(\Êø’\Ç\ï²j‡v‚\Ùo\ò\ÛW.‡)d}À[>¡\ğ5hIG¥\ÄC¡p\Ã;	…¿2¸\Âfx:\æHRa#LŠ‚–Ú¤I…\ë°\ÄH\ÎÚ¼¹™\ÂU\í¯x\\\áP\Û	‘-Z‚\0\Ê\×ş- \Z=TØ‚†Å«¸\ÂM\Ø\åx«\õ~…X\Ş\Çw\n‡a34´H\Æ@uPa»\à¼\à-\â\n\ïD»~\ävÀ\0?]‹\ï\Ä-¢\n1\Z\ÛRa¬\á˜ø\ßû¾ho»MšP1!¯~ø\ZFÈ½P§²b\ã\nƒ€`	Wü/@\Ó^ıLH\Ç\íS(¬6c\Í\ÌÛ£\r;2>\ö*\Ä\ö¹s\Éa´ÀTˆ&\Ûp’\n\ã­\Ç\âz5K~z%¯áŠ¿P\Ù\÷]…O\\a#\íC\n1\Ø	áˆšª›‰—ù\Éa”>b0\ï\ôa¼\èº\ï[¢k]Wƒ[t\ğÑ	…Â[¡\ğ\Ïq\n\Û\ØX\Øù©\n±”\'Q™\Èp\ÆZ´*„QxSøG\ô†DTv‹24†Gû¿x\å£PR!\ÉoP¸Š]¿\Æ:¦+ƒ\Ën^\ì(\Ä^¼R\Ã\É \Â@a\á/WD\á=]yæ‹¦E§iüdV\ï\'b\Ô\ÚHQÍ«I§	cc€5KUX®\ÑI4išB<	\òÿ»-ü¬U\ØL(lk± .H\ß\Æ\î\ØF3\ó-h¾5¿Ç\Â\Â?-Ÿ^\å\Õ+n¬©\n\ërx‹7iªB¸ÿ_~±9V\Â*C…X\É\èˆ\ß\Ò\Â\êaˆ¦¿‰†¯\Ë{‹ˆ‚ŸR¶…B\ğm\Ù\Îÿøˆ”ª0hˆd^¤*t\Ä\ğ^C94G®\nqş¨¹bZ\ó7¸M#\Z\ì\ÙfZ\äÀIS~Š‰\×\ã˜\ßş\'JJS\Ø	\Ó\ï%\ái\n1\à\'Ì ´Á\à-%#\n¡\Ó\âk>i\Õ>\Æ\Ğ$cy\Şk|^\Å\Õ\ŞÊ‹6˜ˆ)\nWrÒŠ³ M\ç\õ\Ø~L\á\Û\0\Ë4¡\ğ-\ì¸a\Ì?\â\nCŸ•\Ô\Ñ¢¾_…+haT\Ô\Şo\ğ\ä/\Í\à&M-˜°6\Ãš\äk(¢·dl\ä´;\Û\Ú	\n\äÔ¥\Âu´\ßn\â2vÃ‘«\áº\"†·›»ûÀ›\î8X:üœ±\Él§9\\¯ÛÛ‰®\ëŠtn\Å´\İL5ù)\Î8\ò}\Û\ËVj\Ö7w™\0…»#‡]\Ó»,†N-Z\ä¯!‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚øÿu\ñ\Ê\Ò\Ò\â\0\0\0\0IEND®B`‚'),(44,'KOMMMASD',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\á\0\0\0\á\0\0\0	m\"H\0\0\0´PLTEÿÿÿ\0ˆ\Ì\0\0\0\0€\É\0…\Ë\0~\È\0ƒ\Ên­\Û\0\É\0„\Ë\Ğ\ã\ò\0|\È\ô\ô\ôüüü‘‘‘§§§\É\É\É\Ó\Ó\Óyyy111\â\ââ‡‡‡®®®QQQzzzŒ¼\á\ß\ì\ö\ï\öû\×\ç\ôooo\Ã\Ã\Ã\è\òù¢\È\æ¸\Õì¡¡¡µ\Ó\ë5•\ÑMÕ‡º\àAAAa§\Ø\Ç\Ş\ğy²\Ü\ì\ìì»»»aaa›\ÅåŠ»\áDš\Ó%%%;;;\Z\Z\Z˜˜˜LLLfff!!!^¥\Ø666ŒŒŒ]\İ(O\0\0\nzIDATxœ\íœg{\â¼†Á\rSŒ’\ĞbÀú¦\în6ÿÿ\ÍHr\ÃŠy\åœk\î/qÀ–\õH3$[I¡@AAAAAAAAAA\Ä5\èu+‹\Ñh´X\ô{ª\ë’5o9-š¦©Û€®³#ş0zT]¯lX<øU\İ.\Å†e›\å\Òä§«•t\İ\Ú‘i›ş¶«º–g\Ó]\ê\öu\Ë\ô=\ÕU=‹Å³Yş^\ì\Éå‹Ö…o\Ñ}‘\ÕÒ\ò\×\î\óiú€²9S]\í\ãYVO\ÖX\ÖHuÍcaX\ç\è\Ì\éOÕ¥y®¾\"x\ÎBuı¿£\ç\Û„n\Ìy6V\0cOU‹8Ä¤z©>F¹˜\ßd\ô²È’\Ñ\È\ë\ğ¿½\Äcb­|J\ô²\È$–\ó¨£lBTH,:ª\õ\ì\Ğ\ÏR “\è«”¤w\ö<fVIµ¤ş\Å\ã`s¢ZSŒ™µ@&1O†šqrr•ŠW\Ğ\Ç\Ğ=Õº¶Î¶\÷J\ÌË\Ñ\Ën¨c-UK”}\ât2\Õ|Lm¯a3#¸¼Z²#™\è\\+\ÛS-\á]\ÉH9y§™\Ï\×B£\ÚW­¯P\ĞM~\Z\æat6•\÷ı\ç\\<^tœ^¯\÷ø\Ø\í\öû•#\é3ºœG \Çqœ<Ko¾œız\Øz“Ñ¢Ò½üİ®\Ó\ë\ö#o;+}>û\ğ\ÊFı¼¦j”Ë†eY¶n\óÈ³‹şt^Z>x\Ó\Ü\ï\ö‰=•\Å\Ä\ÛşZ¢\"Ÿ¬(«l<¿•»\é\"e\Ùd\0¼\Îf\õ­2L«\È2ê³´œAg‡zªø%¾ü¶))Y˜\ê•\ğ¤j\ów\óø~>\êz™[\Å\çg©´\\Î˜¸\í\ö\ñk²\\–J\ó\Ï\é\ô\Ù\÷}xUš0 :W¬°0\ZM¼\Éd[,XP\ö»`†\Ãm+ ³šI60‡\É\ØœŞ£HĞ’\ê\÷†\Ø=\Âb\Êƒ¾\Ú?\ÅW{`8,¶³\å|\Ê,”Ç¨\éYUÜ‹z\Òb\ÊV\Äctt˜ù¼T‚\\Œ\0°dvS®\Æü¦¼c8º\â\'R&\Z\'/‚\îD›\ñ}¦\r…±\ñ’ÙŒ·—\ğ\Ö)¨Õ…Ã€qYh¯¬+\\>?Ch\Â0€ƒ>›ª¿\Ã	#–\Ù.x\ïCfu\Í\àªl*¨¸\Ï8jY|\äc!ù€Fƒ	\Ã\ÆQe„ı†‹\éi\Èp×«\Şu|‡u™::\rŸ²\èqø\ß}¾±Ÿ#ŒF‡\Ü+‰Ù¥Xa\ÜD\å\ÜV>`¢,A1™LpN€,`j ™@º\ÍX·M\Ãn“>SJm\ÅNSª‚\"”\Å\'ŸkŸ?úG}Fê¶”\Ïjş\ß\éÍ§\Óp‚\ók6l\à4FX\Û\îRn˜•\ÊfËƒ\ösŠ3qœ7|şGJ\öQ1!Yø\Ø,VŠ_j\ğ…†p’ªnI\n‰†™¦›¡\Í\è|yb¥xb…½\è\ã\à\Ğo¸\Õ<Ag\â\0\ÎUEªa®a‡±±ÁW¾VrÚ¦|}X\ğ\Í\è\âüFÌ»O\ó¦†C;X!ª´±ªpY˜ı#1x¼\ÕeİyÁ\'ÓD—\î»+ˆ³\á“\İ¼.¢=”#¶•‡|³+>\ó.\ÍDi\åšof”\È5\õY[\Õ\ê€k¾|2\ó\ğ\Ú\"²‚\Ê\õ\Ã=g›\õ¯€j\Æ\n\äZ^S\ÎI^/s’…@\öû\ö\0;F\Êy¼Fœ\æj_[–; T?\ÎO\ğ™ışROµ¦ÅŒ%Z\Ê\ß&\ée\ë§ùJBN?\ËT\Ì\ã^}¶\È\ÈnŸa\åg$Œ²\ÈJb^ÿf&³¥¢‘\ã?\í\ê¦\ï9\r\Ë\ÏcJ.ş\ËbQWıû;.ú#YF5G“\Ñ=,\ì\ö[EÕ¯|Á™ŸÛF5ûº¿gQ<+u?_s\íƒx\ö\É\Z\õ¢\ò7§±=M£mxªk|:^\ñ\Øa˜ş\ë?I¥d~ÿ\÷ù†m–r\ğ\èşlF%\İ\ÜÿO†K7\ç?\ä\ß} ¿ı´L\Ø\×Ó†»irÿo0\åq\á-§¾lÿ-û\ó‡\ÉO\ÜO\öÿf¾İ– ‚ ‚ ˆ\Âj¥ºŒ\Ú\ê\ò%‰3h\İ\Ê\ãzK\ï4\Æ\ÇZ|±n\İÖ‚›Z.üÜ·ÂŠ\ß›Wşº.¤\àF¢\õ\Z­Ö\×a\×\Zˆ{µ[P‰—w!²=h\Õ\ñ`Üº—ø7\íƒ\nY\âğ–•‡…×4Á¯\Ê;lH5š†\Ò\ØG\â“\á?ù6(2åµ \0¸V\È\íhxÄŠ\Ôò»¨D\á^VB\ã-\ÖdM-?hışF\á\r?ªK+¸\ô½\Ñ\ÃÏ¶üJûJWÈ›\ãePK	\ï\Ú\İ\î}Ü AX´§…\Ú\ÛJ~\Ék\Í\Ö\Z6;P¼+\òr;_\õ:k‡\÷zıKH8Ô‰B\Ğ\Ão\ò¦iON\ĞZT¨m\Òb\íê±œe4w\î\Ã*|/›²)c\n\åEBaK¶.V¬U(\Êø’\Ç\ï²j‡v‚\Ùo\ò\ÛW.‡)d}À[>¡\ğ5hIG¥\ÄC¡p\Ã;	…¿2¸\Âfx:\æHRa#LŠ‚–Ú¤I…\ë°\ÄH\ÎÚ¼¹™\ÂU\í¯x\\\áP\Û	‘-Z‚\0\Ê\×ş- \Z=TØ‚†Å«¸\ÂM\Ø\åx«\õ~…X\Ş\Çw\n‡a34´H\Æ@uPa»\à¼\à-\â\n\ïD»~\ävÀ\0?]‹\ï\Ä-¢\n1\Z\ÛRa¬\á˜ø\ßû¾ho»MšP1!¯~ø\ZFÈ½P§²b\ã\nƒ€`	Wü/@\Ó^ıLH\Ç\íS(¬6c\Í\ÌÛ£\r;2>\ö*\Ä\ö¹s\Éa´ÀTˆ&\Ûp’\n\ã­\Ç\âz5K~z%¯áŠ¿P\Ù\÷]…O\\a#\íC\n1\Ø	áˆšª›‰—ù\Éa”>b0\ï\ôa¼\èº\ï[¢k]Wƒ[t\ğÑ	…Â[¡\ğ\Ïq\n\Û\ØX\Øù©\n±”\'Q™\Èp\ÆZ´*„QxSøG\ô†DTv‹24†Gû¿x\å£PR!\ÉoP¸Š]¿\Æ:¦+ƒ\Ën^\ì(\Ä^¼R\Ã\É \Â@a\á/WD\á=]yæ‹¦E§iüdV\ï\'b\Ô\ÚHQÍ«I§	cc€5KUX®\ÑI4išB<	\òÿ»-ü¬U\ØL(lk± .H\ß\Æ\î\ØF3\ó-h¾5¿Ç\Â\Â?-Ÿ^\å\Õ+n¬©\n\ërx‹7iªB¸ÿ_~±9V\Â*C…X\É\èˆ\ß\Ò\Â\êaˆ¦¿‰†¯\Ë{‹ˆ‚ŸR¶…B\ğm\Ù\Îÿøˆ”ª0hˆd^¤*t\Ä\ğ^C94G®\nqş¨¹bZ\ó7¸M#\Z\ì\ÙfZ\äÀIS~Š‰\×\ã˜\ßş\'JJS\Ø	\Ó\ï%\ái\n1\à\'Ì ´Á\à-%#\n¡\Ó\âk>i\Õ>\Æ\Ğ$cy\Şk|^\Å\Õ\ŞÊ‹6˜ˆ)\nWrÒŠ³ M\ç\õ\Ø~L\á\Û\0\Ë4¡\ğ-\ì¸a\Ì?\â\nCŸ•\Ô\Ñ¢¾_…+haT\Ô\Şo\ğ\ä/\Í\à&M-˜°6\Ãš\äk(¢·dl\ä´;\Û\Ú	\n\äÔ¥\Âu´\ßn\â2vÃ‘«\áº\"†·›»ûÀ›\î8X:üœ±\Él§9\\¯ÛÛ‰®\ëŠtn\Å´\İL5ù)\Î8\ò}\Û\ËVj\Ö7w™\0…»#‡]\Ó»,†N-Z\ä¯!‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚øÿu\ñ\Ê\Ò\Ò\â\0\0\0\0IEND®B`‚'),(45,'KOMMMASD',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\á\0\0\0\á\0\0\0	m\"H\0\0\0´PLTEÿÿÿ\0ˆ\Ì\0\0\0\0€\É\0…\Ë\0~\È\0ƒ\Ên­\Û\0\É\0„\Ë\Ğ\ã\ò\0|\È\ô\ô\ôüüü‘‘‘§§§\É\É\É\Ó\Ó\Óyyy111\â\ââ‡‡‡®®®QQQzzzŒ¼\á\ß\ì\ö\ï\öû\×\ç\ôooo\Ã\Ã\Ã\è\òù¢\È\æ¸\Õì¡¡¡µ\Ó\ë5•\ÑMÕ‡º\àAAAa§\Ø\Ç\Ş\ğy²\Ü\ì\ìì»»»aaa›\ÅåŠ»\áDš\Ó%%%;;;\Z\Z\Z˜˜˜LLLfff!!!^¥\Ø666ŒŒŒ]\İ(O\0\0\nzIDATxœ\íœg{\â¼†Á\rSŒ’\ĞbÀú¦\în6ÿÿ\ÍHr\ÃŠy\åœk\î/qÀ–\õH3$[I¡@AAAAAAAAAA\Ä5\èu+‹\Ñh´X\ô{ª\ë’5o9-š¦©Û€®³#ş0zT]¯lX<øU\İ.\Å†e›\å\Òä§«•t\İ\Ú‘i›ş¶«º–g\Ó]\ê\öu\Ë\ô=\ÕU=‹Å³Yş^\ì\Éå‹Ö…o\Ñ}‘\ÕÒ\ò\×\î\óiú€²9S]\í\ãYVO\ÖX\ÖHuÍcaX\ç\è\Ì\éOÕ¥y®¾\"x\ÎBuı¿£\ç\Û„n\Ìy6V\0cOU‹8Ä¤z©>F¹˜\ßd\ô²È’\Ñ\È\ë\ğ¿½\Äcb­|J\ô²\È$–\ó¨£lBTH,:ª\õ\ì\Ğ\ÏR “\è«”¤w\ö<fVIµ¤ş\Å\ã`s¢ZSŒ™µ@&1O†šqrr•ŠW\Ğ\Ç\Ğ=Õº¶Î¶\÷J\ÌË\Ñ\Ën¨c-UK”}\ât2\Õ|Lm¯a3#¸¼Z²#™\è\\+\ÛS-\á]\ÉH9y§™\Ï\×B£\ÚW­¯P\ĞM~\Z\æat6•\÷ı\ç\\<^tœ^¯\÷ø\Ø\í\öû•#\é3ºœG \Çqœ<Ko¾œız\Øz“Ñ¢Ò½üİ®\Ó\ë\ö#o;+}>û\ğ\ÊFı¼¦j”Ë†eY¶n\óÈ³‹şt^Z>x\Ó\Ü\ï\ö‰=•\Å\Ä\ÛşZ¢\"Ÿ¬(«l<¿•»\é\"e\Ùd\0¼\Îf\õ­2L«\È2ê³´œAg‡zªø%¾ü¶))Y˜\ê•\ğ¤j\ów\óø~>\êz™[\Å\çg©´\\Î˜¸\í\ö\ñk²\\–J\ó\Ï\é\ô\Ù\÷}xUš0 :W¬°0\ZM¼\Éd[,XP\ö»`†\Ãm+ ³šI60‡\É\ØœŞ£HĞ’\ê\÷†\Ø=\Âb\Êƒ¾\Ú?\ÅW{`8,¶³\å|\Ê,”Ç¨\éYUÜ‹z\Òb\ÊV\Äctt˜ù¼T‚\\Œ\0°dvS®\Æü¦¼c8º\â\'R&\Z\'/‚\îD›\ñ}¦\r…±\ñ’ÙŒ·—\ğ\Ö)¨Õ…Ã€qYh¯¬+\\>?Ch\Â0€ƒ>›ª¿\Ã	#–\Ù.x\ïCfu\Í\àªl*¨¸\Ï8jY|\äc!ù€Fƒ	\Ã\ÆQe„ı†‹\éi\Èp×«\Şu|‡u™::\rŸ²\èqø\ß}¾±Ÿ#ŒF‡\Ü+‰Ù¥Xa\ÜD\å\ÜV>`¢,A1™LpN€,`j ™@º\ÍX·M\Ãn“>SJm\ÅNSª‚\"”\Å\'ŸkŸ?úG}Fê¶”\Ïjş\ß\éÍ§\Óp‚\ók6l\à4FX\Û\îRn˜•\ÊfËƒ\ösŠ3qœ7|şGJ\öQ1!Yø\Ø,VŠ_j\ğ…†p’ªnI\n‰†™¦›¡\Í\è|yb¥xb…½\è\ã\à\Ğo¸\Õ<Ag\â\0\ÎUEªa®a‡±±ÁW¾VrÚ¦|}X\ğ\Í\è\âüFÌ»O\ó¦†C;X!ª´±ªpY˜ı#1x¼\ÕeİyÁ\'ÓD—\î»+ˆ³\á“\İ¼.¢=”#¶•‡|³+>\ó.\ÍDi\åšof”\È5\õY[\Õ\ê€k¾|2\ó\ğ\Ú\"²‚\Ê\õ\Ã=g›\õ¯€j\Æ\n\äZ^S\ÎI^/s’…@\öû\ö\0;F\Êy¼Fœ\æj_[–; T?\ÎO\ğ™ışROµ¦ÅŒ%Z\Ê\ß&\ée\ë§ùJBN?\ËT\Ì\ã^}¶\È\ÈnŸa\åg$Œ²\ÈJb^ÿf&³¥¢‘\ã?\í\ê¦\ï9\r\Ë\ÏcJ.ş\ËbQWıû;.ú#YF5G“\Ñ=,\ì\ö[EÕ¯|Á™ŸÛF5ûº¿gQ<+u?_s\íƒx\ö\É\Z\õ¢\ò7§±=M£mxªk|:^\ñ\Øa˜ş\ë?I¥d~ÿ\÷ù†m–r\ğ\èşlF%\İ\ÜÿO†K7\ç?\ä\ß} ¿ı´L\Ø\×Ó†»irÿo0\åq\á-§¾lÿ-û\ó‡\ÉO\ÜO\öÿf¾İ– ‚ ‚ ˆ\Âj¥ºŒ\Ú\ê\ò%‰3h\İ\Ê\ãzK\ï4\Æ\ÇZ|±n\İÖ‚›Z.üÜ·ÂŠ\ß›Wşº.¤\àF¢\õ\Z­Ö\×a\×\Zˆ{µ[P‰—w!²=h\Õ\ñ`Üº—ø7\íƒ\nY\âğ–•‡…×4Á¯\Ê;lH5š†\Ò\ØG\â“\á?ù6(2åµ \0¸V\È\íhxÄŠ\Ôò»¨D\á^VB\ã-\ÖdM-?hışF\á\r?ªK+¸\ô½\Ñ\ÃÏ¶üJûJWÈ›\ãePK	\ï\Ú\İ\î}Ü AX´§…\Ú\ÛJ~\Ék\Í\Ö\Z6;P¼+\òr;_\õ:k‡\÷zıKH8Ô‰B\Ğ\Ão\ò¦iON\ĞZT¨m\Òb\íê±œe4w\î\Ã*|/›²)c\n\åEBaK¶.V¬U(\Êø’\Ç\ï²j‡v‚\Ùo\ò\ÛW.‡)d}À[>¡\ğ5hIG¥\ÄC¡p\Ã;	…¿2¸\Âfx:\æHRa#LŠ‚–Ú¤I…\ë°\ÄH\ÎÚ¼¹™\ÂU\í¯x\\\áP\Û	‘-Z‚\0\Ê\×ş- \Z=TØ‚†Å«¸\ÂM\Ø\åx«\õ~…X\Ş\Çw\n‡a34´H\Æ@uPa»\à¼\à-\â\n\ïD»~\ävÀ\0?]‹\ï\Ä-¢\n1\Z\ÛRa¬\á˜ø\ßû¾ho»MšP1!¯~ø\ZFÈ½P§²b\ã\nƒ€`	Wü/@\Ó^ıLH\Ç\íS(¬6c\Í\ÌÛ£\r;2>\ö*\Ä\ö¹s\Éa´ÀTˆ&\Ûp’\n\ã­\Ç\âz5K~z%¯áŠ¿P\Ù\÷]…O\\a#\íC\n1\Ø	áˆšª›‰—ù\Éa”>b0\ï\ôa¼\èº\ï[¢k]Wƒ[t\ğÑ	…Â[¡\ğ\Ïq\n\Û\ØX\Øù©\n±”\'Q™\Èp\ÆZ´*„QxSøG\ô†DTv‹24†Gû¿x\å£PR!\ÉoP¸Š]¿\Æ:¦+ƒ\Ën^\ì(\Ä^¼R\Ã\É \Â@a\á/WD\á=]yæ‹¦E§iüdV\ï\'b\Ô\ÚHQÍ«I§	cc€5KUX®\ÑI4išB<	\òÿ»-ü¬U\ØL(lk± .H\ß\Æ\î\ØF3\ó-h¾5¿Ç\Â\Â?-Ÿ^\å\Õ+n¬©\n\ërx‹7iªB¸ÿ_~±9V\Â*C…X\É\èˆ\ß\Ò\Â\êaˆ¦¿‰†¯\Ë{‹ˆ‚ŸR¶…B\ğm\Ù\Îÿøˆ”ª0hˆd^¤*t\Ä\ğ^C94G®\nqş¨¹bZ\ó7¸M#\Z\ì\ÙfZ\äÀIS~Š‰\×\ã˜\ßş\'JJS\Ø	\Ó\ï%\ái\n1\à\'Ì ´Á\à-%#\n¡\Ó\âk>i\Õ>\Æ\Ğ$cy\Şk|^\Å\Õ\ŞÊ‹6˜ˆ)\nWrÒŠ³ M\ç\õ\Ø~L\á\Û\0\Ë4¡\ğ-\ì¸a\Ì?\â\nCŸ•\Ô\Ñ¢¾_…+haT\Ô\Şo\ğ\ä/\Í\à&M-˜°6\Ãš\äk(¢·dl\ä´;\Û\Ú	\n\äÔ¥\Âu´\ßn\â2vÃ‘«\áº\"†·›»ûÀ›\î8X:üœ±\Él§9\\¯ÛÛ‰®\ëŠtn\Å´\İL5ù)\Î8\ò}\Û\ËVj\Ö7w™\0…»#‡]\Ó»,†N-Z\ä¯!‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚øÿu\ñ\Ê\Ò\Ò\â\0\0\0\0IEND®B`‚');
/*!40000 ALTER TABLE `tbl_brands` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_departmants`
--

DROP TABLE IF EXISTS `tbl_departmants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_departmants` (
  `departmant_id` int NOT NULL AUTO_INCREMENT,
  `departmant_name` varchar(100) NOT NULL,
  PRIMARY KEY (`departmant_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_departmants`
--

LOCK TABLES `tbl_departmants` WRITE;
/*!40000 ALTER TABLE `tbl_departmants` DISABLE KEYS */;
INSERT INTO `tbl_departmants` VALUES (1,'Bilgi Ä°ÅŸlem'),(2,'Ä°nsan KaynaklarÄ±'),(3,'SatÄ±n Alma');
/*!40000 ALTER TABLE `tbl_departmants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_logs`
--

DROP TABLE IF EXISTS `tbl_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_logs` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `printer_id` int DEFAULT NULL,
  `action` varchar(255) DEFAULT NULL,
  `performed_by` varchar(100) DEFAULT NULL,
  `timestamp` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`),
  KEY `printer_id` (`printer_id`),
  CONSTRAINT `tbl_logs_ibfk_1` FOREIGN KEY (`printer_id`) REFERENCES `tbl_printers` (`printer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_logs`
--

LOCK TABLES `tbl_logs` WRITE;
/*!40000 ALTER TABLE `tbl_logs` DISABLE KEYS */;
INSERT INTO `tbl_logs` VALUES (1,1,'Toner deÄŸiÅŸtirildi','admin','2025-05-19 12:41:40'),(2,1,'IP adresi gÃ¼ncellendi','mehmet','2025-05-19 12:41:40'),(3,2,'YazÄ±cÄ± yeniden baÅŸlatÄ±ldÄ±','admin','2025-05-19 12:41:40');
/*!40000 ALTER TABLE `tbl_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_models`
--

DROP TABLE IF EXISTS `tbl_models`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_models` (
  `model_id` int NOT NULL AUTO_INCREMENT,
  `brand_id` int DEFAULT NULL,
  `model_name` varchar(100) NOT NULL,
  `model_logo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`model_id`),
  KEY `brand_id` (`brand_id`),
  CONSTRAINT `tbl_models_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `tbl_brands` (`brand_id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_models`
--

LOCK TABLES `tbl_models` WRITE;
/*!40000 ALTER TABLE `tbl_models` DISABLE KEYS */;
INSERT INTO `tbl_models` VALUES (1,1,'LaserJet Pro M404n','m404n_logo.png'),(2,2,'PIXMA G3411','g3411_logo.png'),(3,1,'LaserJet Pro M404n','m404n_logo.png'),(4,1,'OfficeJet Pro 9015','officejet9015_logo.png'),(5,2,'PIXMA G3411','g3411_logo.png'),(6,2,'imageCLASS MF743Cdw','mf743cdw_logo.png'),(7,3,'EcoTank L3150','l3150_logo.png'),(8,3,'WorkForce WF-2830','wf2830_logo.png'),(9,7,'HL-L2370DW','hl2370dw_logo.png'),(10,7,'MFC-L2750DW','mfc2750dw_logo.png'),(11,8,'Xpress M2020W','m2020w_logo.png'),(12,8,'SL-C430W','slc430w_logo.png'),(13,9,'MS415dn','ms415dn_logo.png'),(14,10,'WorkCentre 6515','6515_logo.png'),(15,11,'SP C261SFNw','spc261sfnw_logo.png'),(16,12,'Dell E525w','e525w_logo.png'),(17,13,'TASKalfa 3252ci','taskalfa3252ci_logo.png'),(18,14,'AR-6020','ar6020_logo.png'),(19,15,'C834dn','c834dn_logo.png'),(20,16,'KX-MB2130','kxmb2130_logo.png'),(21,17,'bizhub C258','bizhubc258_logo.png'),(22,18,'ScanSnap iX1500','ix1500_logo.png'),(23,19,'e-STUDIO2518A','estudio2518a_logo.png'),(24,20,'ZT410','zt410_logo.png'),(25,21,'PX940','px940_logo.png'),(26,22,'LX500e','lx500e_logo.png'),(27,23,'LabelWriter 450','labelwriter450_logo.png'),(28,24,'Seiko SLP-DX420','slpdx420_logo.png'),(29,25,'CT-S310II','cts310ii_logo.png'),(30,26,'TSC TE210','te210_logo.png'),(31,27,'PM43','pm43_logo.png'),(32,28,'CT4-LX','ct4lx_logo.png'),(33,29,'P2500DN','p2500dn_logo.png'),(34,30,'LP 3125','lp3125_logo.png'),(35,31,'DP C4500','dpc4500_logo.png'),(36,32,'DP-5020','dp5020_logo.png'),(37,33,'M-210i','m210i_logo.png'),(38,34,'DS-62','ds62_logo.png'),(39,35,'C2026','c2026_logo.png'),(40,36,'MC363dn','mc363dn_logo.png'),(41,37,'C3850','c3850_logo.png'),(42,38,'CF2201','cf2201_logo.png'),(43,39,'PC310','pc310_logo.png');
/*!40000 ALTER TABLE `tbl_models` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_part_type`
--

DROP TABLE IF EXISTS `tbl_part_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_part_type` (
  `part_type_id` int NOT NULL AUTO_INCREMENT,
  `part_type_name` varchar(100) NOT NULL,
  `explanation` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`part_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_part_type`
--

LOCK TABLES `tbl_part_type` WRITE;
/*!40000 ALTER TABLE `tbl_part_type` DISABLE KEYS */;
INSERT INTO `tbl_part_type` VALUES (1,'Toner','YazÄ±cÄ±ya Ã¶zel toner kartuÅŸu'),(2,'Drum','GÃ¶rÃ¼ntÃ¼leme tamburu');
/*!40000 ALTER TABLE `tbl_part_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_parts`
--

DROP TABLE IF EXISTS `tbl_parts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_parts` (
  `part_id` int NOT NULL AUTO_INCREMENT,
  `model_id` int DEFAULT NULL,
  `part_type_id` int DEFAULT NULL,
  `part_name` varchar(100) NOT NULL,
  PRIMARY KEY (`part_id`),
  KEY `model_id` (`model_id`),
  KEY `part_type_id` (`part_type_id`),
  CONSTRAINT `tbl_parts_ibfk_1` FOREIGN KEY (`model_id`) REFERENCES `tbl_models` (`model_id`),
  CONSTRAINT `tbl_parts_ibfk_2` FOREIGN KEY (`part_type_id`) REFERENCES `tbl_part_type` (`part_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_parts`
--

LOCK TABLES `tbl_parts` WRITE;
/*!40000 ALTER TABLE `tbl_parts` DISABLE KEYS */;
INSERT INTO `tbl_parts` VALUES (1,1,1,'HP 59X Toner'),(2,2,1,'Canon GI-490 MÃ¼rekkep');
/*!40000 ALTER TABLE `tbl_parts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_printers`
--

DROP TABLE IF EXISTS `tbl_printers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_printers` (
  `printer_id` int NOT NULL AUTO_INCREMENT,
  `brand_id` int DEFAULT NULL,
  `model_id` int DEFAULT NULL,
  `departmant_id` int DEFAULT NULL,
  `printer_sn` varchar(100) DEFAULT NULL,
  `printer_ip` varchar(50) DEFAULT NULL,
  `delivery_date` date DEFAULT NULL,
  `is_deleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`printer_id`),
  KEY `brand_id` (`brand_id`),
  KEY `model_id` (`model_id`),
  KEY `departmant_id` (`departmant_id`),
  CONSTRAINT `tbl_printers_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `tbl_brands` (`brand_id`),
  CONSTRAINT `tbl_printers_ibfk_2` FOREIGN KEY (`model_id`) REFERENCES `tbl_models` (`model_id`),
  CONSTRAINT `tbl_printers_ibfk_3` FOREIGN KEY (`departmant_id`) REFERENCES `tbl_departmants` (`departmant_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_printers`
--

LOCK TABLES `tbl_printers` WRITE;
/*!40000 ALTER TABLE `tbl_printers` DISABLE KEYS */;
INSERT INTO `tbl_printers` VALUES (1,1,1,1,'SN12345678','192.168.1.10',NULL,0),(2,2,2,2,'SN87654321','192.168.1.11',NULL,0),(3,1,1,1,'SN123123','123412321',NULL,0),(7,26,1,1,'SM123123213','10.25.12.215',NULL,1),(12,1,4,1,'1516512','192.168.1.2','2025-06-22',1),(14,1,4,2,'SN9871239941','10.7.7152.12','2025-06-18',1);
/*!40000 ALTER TABLE `tbl_printers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `full_name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `role` enum('admin','user','viewer') DEFAULT 'user',
  `is_active` tinyint(1) DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES (1,'admin','240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9','Sistem YÃ¶neticisi','admin@example.com','admin',1,'2025-05-19 09:23:03'),(2,'mehmet','248b592e88edbb4f62609b36a4b6640a5e65c6759b2adae2c8a7a24378e0274e','Mehmet YÄ±lmaz','mehmet@example.com','user',1,'2025-05-19 09:23:03');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-07-09 11:53:50
