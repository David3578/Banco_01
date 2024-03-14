﻿using Biblioteca_Clase;
Cliente cliente1 = new Cliente("David", "Fernandez", 1000m, 123456789);
cliente1.Acreditar(500);
cliente1.Debitar(200m);
Console.WriteLine("Información del Cliente:");
Console.WriteLine($"Nombre: {cliente1.Nombre} {cliente1.Apellido}");
Console.WriteLine($"Saldo en Efectivo: ${cliente1.SaldoEnEfectivo}");
Console.WriteLine($"Saldo en Cuenta: ${cliente1.Cuenta.Saldo}");
Console.WriteLine($"CBU de la Cuenta: {cliente1.ObtenerCBUCuenta()}");
Console.WriteLine($"Saldo Total: ${cliente1.ObtenerSaldo()}");
