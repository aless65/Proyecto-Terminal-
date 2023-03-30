USE dbTerminal
GO



INSERT INTO gral.tbEstadosCiviles (estciv_Descripcion, estciv_Estado, estciv_UsuarioCreador, estciv_FechaCreacion, estciv_UsuarioModificador, estciv_FechaModificacion)
VALUES	('Soltero(a)', '1', 1, GETDATE(), NULL, GETDATE()),
		('Casado(a)', '1', 1, GETDATE(), NULL, GETDATE()),
		('Divorciado(a)', '1', 1, GETDATE(), NULL, GETDATE()),
		('Viudo(a)', '1', 1, GETDATE(), NULL, GETDATE()),
		('Union Libre', '1', 1, GETDATE(), NULL, GETDATE())
GO


INSERT INTO gral.tbMetodosPago(pago_Descripcion, pago_UsuarioCreador, pago_UsuarioModificador, pago_FechaModificacion)
VALUES ('Efectivo', 1, NULL, NULL)


INSERT INTO gral.tbDepartamentos(dept_ID, dept_Descripcion, dept_Estado, dept_UsuarioCreador, dept_FechaCreacion, dept_UsuarioModificador, dept_FechaModificacion)
VALUES	('01','Atl�ntida', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','Col�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03','Comayagua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04','Cop�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05','Cort�s', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06','Choluteca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07','El Para�so', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08','Francisco Moraz�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('09','Gracias a Dios', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10','Intibuc�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('11','Islas de la Bah�a', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12','La Paz', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13','Lempira', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14','Ocotepeque', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15','Olancho', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16','Santa B�rbara', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17','Valle', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18','Yoro', '1', NULL, GETDATE(), NULL, GETDATE());
GO


INSERT INTO gral.tbMunicipios(dept_ID, muni_ID, muni_Descripcion, muni_Estado, muni_UsuarioCreador, muni_FechaCreacion, muni_UsuarioModificador, muni_FechaModificacion)
VALUES	('01','0101','La Ceiba', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0102','El Porvenir', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0103','Tela', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0104','Jutiapa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0105','La Masica', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0106','San Francisco', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0107','Arizona', '1', NULL, GETDATE(), NULL, GETDATE()),
		('01','0108','Esparta', '1', NULL, GETDATE(), NULL, GETDATE()),
	

		('02','0201','Trujillo', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0202','Balfate', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0203','Iriona', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0204','Lim�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0205','Sab�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0206','Santa Fe', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0207','Santa Rosa de Agu�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0208','Sonaguera', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0209','Tocoa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('02','0210','Bonito Oriental', '1', NULL, GETDATE(), NULL, GETDATE()),


		('03',		'0301',		'Comayagua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0302',		'Ajuterique', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0303',		'El Rosario', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0304',		'Esqu�as', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0305',		'Humuya', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0306',		'La Libertad', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0307',		'Laman�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0308',		'La Trinidad', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0309',		'Lejaman�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0310',		'Me�mbar', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0311',		'Minas de Oro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0312',		'Ojos de Agua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0313',		'San Jer�nimo', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0314',		'San Jos� de Comayagua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0315',		'San Jos� del Potrero', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0316',		'San Luis', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0317',		'San Sebasti�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0318',		'Siguatepeque', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0319',		'Villa de San Antonio', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0320',		'Las Lajas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('03',		'0321',		'Taulab�', '1', NULL, GETDATE(), NULL, GETDATE()),


		('04',	'0401','Santa Rosa de Cop�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0402','Caba�as', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0403','Concepci�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0404','Cop�n Ruinas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0405','Corqu�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0406','Cucuyagua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0407','Dolores', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0408','Dulce Nombre', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0409','El Para�so', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0410','Florida', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0411','La Jigua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0412','La Uni�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0413','Nueva Arcadia', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0414','San Agust�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0415','San Antonio', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0416','San Jer�nimo', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0417','San Jos�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0418','San Juan de Opoa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0419','San Nicol�s', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0420','San Pedro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0421','Santa Rita', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0422','Trinidad de Cop�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('04',	'0423','Veracruz', '1', NULL, GETDATE(), NULL, GETDATE()),


		('05',	'0501','San Pedro Sula', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0502','Choloma', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0503','Omoa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0504','Pimienta', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0505','Potrerillos', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0506','Puerto Cort�s', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0507','San Antonio de Cort�s', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0508','San Francisco de Yojoa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0509','San Manuel', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0510','Santa Cruz de Yojoa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0511','Villanueva', '1', NULL, GETDATE(), NULL, GETDATE()),
		('05',	'0512','La Lima', '1', NULL, GETDATE(), NULL, GETDATE()),


		('06',	'0601','Choluteca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0602','Apacilagua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0603','Concepci�n de Mar�a', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0604','Duyure', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0605','El Corpus', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0606','El Triunfo', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0607','Marcovia', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0608','Morolica', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0609','Namasig�e', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0610','Orocuina', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0611','Pespire', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0612','San Antonio de Flores', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0613','San Isidro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0614','San Jos�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0615','San Marcos de Col�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('06',	'0616','Santa Ana de Yusguare', '1', NULL, GETDATE(), NULL, GETDATE()),


		('07', '0701', 'Yuscar�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0702', 'Alauca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0703', 'Danl�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0704', 'El Para�so', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0705', 'G�inope', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0706', 'Jacaleapa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0707', 'Liure', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0708', 'Morocel�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0709', 'Oropol�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0710', 'Potrerillos', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0711', 'San Antonio de Flores', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0712', 'San Lucas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0713', 'San Mat�as', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0714', 'Soledad', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0715', 'Teupasenti', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0716', 'Texiguat', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0717', 'Vado Ancho', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0718', 'Yauyupe', '1', NULL, GETDATE(), NULL, GETDATE()),
		('07', '0719', 'Trojes', '1', NULL, GETDATE(), NULL, GETDATE()),


		('08', '0801', 'Distrito Central', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0802', 'Alubar�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0803', 'Cedros', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0804', 'Curar�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0805', 'El Porvenir', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0806', 'Guaimaca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0807', 'La Libertad', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0808', 'La Venta', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0809', 'Lepaterique', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0810', 'Maraita', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0811', 'Marale', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0812', 'Nueva Armenia', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0813', 'Ojojona', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0814', 'Orica', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0815', 'Reitoca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0816', 'Sabanagrande', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0817', 'San Antonio de Oriente', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0818', 'San Buenaventura', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0819', 'San Ignacio', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0820', 'San Juan de Flores', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0821', 'San Miguelito', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0822', 'Santa Ana', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0823', 'Santa Luc�a', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0824', 'Talanga', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0825', 'Tatumbla', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0826', 'Valle de �ngeles', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0827', 'Villa de San Francisco', '1', NULL, GETDATE(), NULL, GETDATE()),
		('08', '0828', 'Vallecillo', '1', NULL, GETDATE(), NULL, GETDATE()),


		('09', '0901', 'Puerto Lempira', '1', NULL, GETDATE(), NULL, GETDATE()),
		('09', '0902', 'Brus Laguna', '1', NULL, GETDATE(), NULL, GETDATE()),
		('09', '0903', 'Ahuas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('09', '0904', 'Juan Francisco Bulnes', '1', NULL, GETDATE(), NULL, GETDATE()),
		('09', '0905', 'Ram�n Villeda Morales', '1', NULL, GETDATE(), NULL, GETDATE()),
		('09', '0906', 'Wampusirpe', '1', NULL, GETDATE(), NULL, GETDATE()),


		('10', '1001', 'La Esperanza', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1002', 'Camasca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1003', 'Colomoncagua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1004', 'Concepci�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1005', 'Dolores', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1006', 'Intibuc�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1007', 'Jes�s de Otoro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1008', 'Magdalena', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1009', 'Masaguara', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1010', 'San Antonio', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1011', 'San Isidro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1012', 'San Juan', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1013', 'San Marcos de la Sierra', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1014', 'San Miguel Guancapla', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1015', 'Santa Luc�a', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1016', 'Yamaranguila', '1', NULL, GETDATE(), NULL, GETDATE()),
		('10', '1017', 'San Francisco de Opalaca', '1', NULL, GETDATE(), NULL, GETDATE()),


		('11', '1101', 'Roat�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('11', '1102', 'Guanaja', '1', NULL, GETDATE(), NULL, GETDATE()),
		('11', '1103', 'Jos� Santos Guardiola', '1', NULL, GETDATE(), NULL, GETDATE()),
		('11', '1104', 'Utila', '1', NULL, GETDATE(), NULL, GETDATE()),


		('12', '1201', 'La Paz', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1202', 'Aguanqueterique', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1203', 'Caba�as', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1204', 'Cane', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1205', 'Chinacla', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1206', 'Guajiquiro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1207', 'Lauterique', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1208', 'Marcala', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1209', 'Mercedes de Oriente', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1210', 'Opatoro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1211', 'San Antonio del Norte', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1212', 'San Jos�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1213', 'San Juan', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1214', 'San Pedro de Tutule', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1215', 'Santa Ana', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1216', 'Santa Elena', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1217', 'Santa Mar�a', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1218', 'Santiago de Puringla', '1', NULL, GETDATE(), NULL, GETDATE()),
		('12', '1219', 'Yarula', '1', NULL, GETDATE(), NULL, GETDATE()),


		('13', '1301', 'Gracias', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1302', 'Bel�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1303', 'Candelaria', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1304', 'Cololaca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1305', 'Erandique', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1306', 'Gualcince', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1307', 'Guarita', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1308', 'La Campa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1309', 'La Iguala', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1310', 'Las Flores', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1311', 'La Uni�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1312', 'La Virtud', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1313', 'Lepaera', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1314', 'Mapulaca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1315', 'Piraera', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1316', 'San Andr�s', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1317', 'San Francisco', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1318', 'San Juan Guarita', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1319', 'San Manuel Colohete', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1320', 'San Rafael', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1321', 'San Sebasti�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1322', 'Santa Cruz', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1323', 'Talgua', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1324', 'Tambla', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1325', 'Tomal�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1326', 'Valladolid', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1327', 'Virginia', '1', NULL, GETDATE(), NULL, GETDATE()),
		('13', '1328', 'San Marcos de Caiqu�n', '1', NULL, GETDATE(), NULL, GETDATE()),


		('14', '1401', 'Ocotepeque', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1402', 'Bel�n Gualcho', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1403', 'Concepci�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1404', 'Dolores Merend�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1405', 'Fraternidad', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1406', 'La Encarnaci�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1407', 'La Labor', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1408', 'Lucerna', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1409', 'Mercedes', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1410', 'San Fernando', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1411', 'San Francisco del Valle', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1412', 'San Jorge', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1413', 'San Marcos', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1414', 'Santa Fe', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1415', 'Sensenti', '1', NULL, GETDATE(), NULL, GETDATE()),
		('14', '1416', 'Sinuapa', '1', NULL, GETDATE(), NULL, GETDATE()),


		('15', '1501', 'Juticalpa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1502', 'Campamento', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1503', 'Catacamas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1504', 'Concordia', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1505', 'Dulce Nombre de Culm�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1506', 'El Rosario', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1507', 'Esquipulas del Norte', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1508', 'Gualaco', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1509', 'Guarizama', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1510', 'Guata', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1511', 'Guayape', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1512', 'Jano', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1513', 'La Uni�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1514', 'Mangulile', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1515', 'Manto', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1516', 'Salam�', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1517', 'San Esteban', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1518', 'San Francisco de Becerra', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1519', 'San Francisco de la Paz', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1520', 'Santa Mar�a del Real', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1521', 'Silca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1522', 'Yoc�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('15', '1523', 'Patuca', '1', NULL, GETDATE(), NULL, GETDATE()),


		('16', '1601' , 'Santa B�rbara', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1602' , 'Arada', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1603' , 'Atima', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1604' , 'Azacualpa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1605' , 'Ceguaca', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1606' , 'Concepci�n del Norte', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1607' , 'Concepci�n del Sur', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1608' , 'Chinda', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1609' , 'El N�spero', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1610' , 'Gualala', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1611' , 'Ilama', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1612' , 'Las Vegas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1613' , 'Macuelizo', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1614' , 'Naranjito', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1615' , 'Nuevo Celilac', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1616' , 'Nueva Frontera', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1617' , 'Petoa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1618' , 'Protecci�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1619' , 'Quimist�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1620' , 'San Francisco de Ojuera', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1621' , 'San Jos� de las Colinas', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1622' , 'San Luis', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1623' , 'San Marcos', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1624' , 'San Nicol�s', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1625' , 'San Pedro Zacapa', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1626' , 'San Vicente Centenario', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1627' , 'Santa Rita', '1', NULL, GETDATE(), NULL, GETDATE()),
		('16', '1628' , 'Trinidad', '1', NULL, GETDATE(), NULL, GETDATE()),


		('17', '1701', 'Nacaome', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1702', 'Alianza', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1703', 'Amapala', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1704', 'Aramecina', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1705', 'Caridad', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1706', 'Goascor�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1707', 'Langue', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1708', 'San Francisco de Coray', '1', NULL, GETDATE(), NULL, GETDATE()),
		('17', '1709', 'San Lorenzo', '1', NULL, GETDATE(), NULL, GETDATE()),


		('18', '1801', 'Yoro', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1802', 'Arenal', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1803', 'El Negrito', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1804', 'El Progreso', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1805', 'Joc�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1806', 'Moraz�n', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1807', 'Olanchito', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1808', 'Santa Rita', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1809', 'Sulaco', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1810', 'Victoria', '1', NULL, GETDATE(), NULL, GETDATE()),
		('18', '1811', 'Yorito', '1', NULL, GETDATE(), NULL, GETDATE());
GO


INSERT INTO	term.tbCompania(comp_Nombre, muni_ID, comp_Direccion, comp_UsuarioCreador, comp_UsuarioModificador, comp_FechaModificacion)
VALUES('Mazapan', '0501', 'Por la casa de Selvin XD', 1, NULL, NULL)


INSERT INTO term.tbCargos(carg_Nombre, carg_UsuarioCreador, carg_UsuarioModificador, carg_FechaModificacion)
VALUES ('Conductor(a)', 1, NULL, NULL)


INSERT INTO term.tbTerminales(muni_ID, term_Nombre, term_DireccionExacta, term_CantidadTransportes, term_UsuarioCreador, term_UsuarioModificador, term_FechaModificacion)
VALUES('0501', 'Terminal de San Pedro Sula', 'Salida a la Lima', 200, 1, NULL, NULL)


INSERT INTO term.tbEmpleados(empl_PrimerNombre, empl_SegundoNombre, empl_PrimerApellido, empl_SegundoApellido, empl_DNI, empl_FechaNacimiento, empl_Sexo, empl_Telefono, carg_ID, estciv_ID, muni_ID, empl_UsuarioCreador, empl_UsuarioModificador, empl_FechaModificacion)
VALUES ('Maria', 'Jose','Antonieta', 'De las nieves', '1234567891234', GETDATE(), 'F', '00000000', 1, 1, '0501', 1, NULL, NULL)

DECLARE @PassEncrypt VARBINARY(MAX) = HASHBYTES('SHA2_512', 'AWSD')
INSERT INTO acce.tbUsuarios(usua_Usuario, usua_Clave, usua_EsAdmin, empl_ID, usua_UsuarioCreador, usua_UsuarioModificador, usua_FechaModificacion)
VALUES('AWSD', @PassEncrypt, 1, 1, 1, NULL, NULL)

INSERT INTO term.tbClientes(clie_Nombres, clie_Apellidos, clie_DNI, clie_Sexo, clie_Telefono, 
							clie_Email, clie_UsuarioCreador, clie_UsuarioModificador, clie_FechaModificacion)
VALUES ('Calidonio', 'Panchame', '457214798', 'M', '00000000', 'panchame@gmail.com', 1, NULL, NULL),
		('Sr.obama', 'Obama', '546795214', 'F', '45877454', 'Sr.obama@gmail.com', 1, NULL, NULL)

INSERT INTO term.tbHorarios(hora_FechaSalida, hora_FechaLlegada, hora_Origen, hora_Destino, hora_CantidadPasajeros, hora_Precio ,hora_UsuarioCreador, hora_UsuarioModificador, hora_FechaModificacion)
VALUES(GETDATE(), GETDATE(), '06', '08', 100,  200,1, NULL, NULL)


INSERT INTO term.tbBoletos(bole_Fecha, term_ID, comp_ID, empl_ID, clie_ID, hora_ID, pago_ID, bole_UsuarioCreador, bole_UsuarioModificador, bole_FechaModificacion)
VALUES (GETDATE(), 1, 1, 1, 1, 1, 1, 1, NULL, NULL)
INSERT INTO term.tbHorarios(hora_FechaSalida, hora_FechaLlegada, hora_Origen, hora_Destino, hora_CantidadPasajeros, hora_UsuarioCreador, hora_UsuarioModificador, hora_FechaModificacion)
VALUES(GETDATE(), GETDATE(), '05', '09', 100, 1, NULL, NULL)

/********************** CONSTRAINTS ***********************/

ALTER TABLE gral.tbEstadosCiviles
ADD CONSTRAINT FK_gral_tbEstadosCiviles_estciv_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (estciv_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_gral_tbEstadosCiviles_estciv_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (estciv_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)	
GO


ALTER TABLE gral.tbDepartamentos
ADD CONSTRAINT FK_gral_tbDepartamentos_dept_UsuarioCreador_acce_tbUsuarios_usua_ID	FOREIGN KEY (dept_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_gral_tbDepartamentos_dept_UsuarioModificador_acce_tbUsuarios_usua_ID	FOREIGN KEY (dept_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO	


ALTER TABLE gral.tbMunicipios
ADD CONSTRAINT FK_gral_tbMunicipios_muni_UsuarioCreador_acce_tbUsuarios_usua_ID	FOREIGN KEY (muni_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_gral_tbMunicipios_muni_UsuarioModificador_acce_tbUsuarios_usua_ID	FOREIGN KEY (muni_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE gral.tbMetodosPago
ADD CONSTRAINT FK_gral_tbMetodosPago_pago_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (pago_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_gral_tbMetodosPago_pago_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (pago_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE acce.tbRoles
ADD CONSTRAINT FK_acce_tbRoles_role_UsuarioCreador_tbUsuarios_usua_ID FOREIGN KEY (role_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_acce_tbRoles_role_UsuarioModificador_tbUsuarios_usua_ID FOREIGN KEY (role_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO

ALTER TABLE acce.tbPantallas
ADD CONSTRAINT FK_acce_tbPantallas_pant_UsuarioCreador_tbUsuarios_usua_ID FOREIGN KEY (pant_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_acce_tbPantallas_pant_UsuarioModificador_tbUsuarios_usua_ID FOREIGN KEY (pant_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE acce.tbRolesXPantallas
ADD CONSTRAINT FK_acce_tbRolesXPantallas_tbUsuarios_usua_ID FOREIGN KEY (usua_ID) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_acce_tbRolesXPantallas_roleXpant_UsuarioCreador_tbUsuarios_usua_ID FOREIGN KEY (roleXpant_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_acce_tbRolesXPantallas_roleXpant_UsuarioModificador_tbUsuarios_usua_ID FOREIGN KEY (roleXpant_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO



ALTER TABLE acce.tbUsuarios
ADD CONSTRAINT FK_acce_tbUsuarios_term_tbEmpleados_empl_ID FOREIGN KEY (empl_ID) REFERENCES term.tbEmpleados (empl_ID),
	CONSTRAINT FK_acce_tbUsuarios_usua_UsuarioCreador_tbUsuarios_usua_ID FOREIGN KEY (usua_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_acce_tbUsuarios_usua_UsuarioModificador_tbUsuarios_usua_ID FOREIGN KEY (usua_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbCargos
ADD CONSTRAINT FK_term_tbCargos_carg_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (carg_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbCargos_carg_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (carg_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbEmpleados
ADD CONSTRAINT FK_term_tbEmpleados_empl_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (empl_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbEmpleados_empl_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (empl_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbTerminales
ADD CONSTRAINT FK_term_tbTerminales_term_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (term_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbTerminales_term_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (term_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbCompania
ADD CONSTRAINT FK_term_tbCompania_comp_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (comp_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbCompania_comp_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (comp_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbClientes
ADD CONSTRAINT FK_term_tbClientes_clie_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (clie_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbClientes_clie_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (clie_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbHorarios
ADD CONSTRAINT FK_term_tbHorarios_hora_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (hora_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbHorarios_hora_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (hora_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO


ALTER TABLE term.tbBoletos
ADD CONSTRAINT FK_term_tbBoletos_bole_UsuarioCreador_acce_tbUsuarios_usua_ID FOREIGN KEY (bole_UsuarioCreador) REFERENCES acce.tbUsuarios (usua_ID),
	CONSTRAINT FK_term_tbBoletos_bole_UsuarioModificador_acce_tbUsuarios_usua_ID FOREIGN KEY (bole_UsuarioModificador) REFERENCES acce.tbUsuarios (usua_ID)
GO
