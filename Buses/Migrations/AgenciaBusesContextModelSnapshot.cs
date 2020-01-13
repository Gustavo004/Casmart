﻿// <auto-generated />
using System;
using Buses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Buses.Migrations
{
    [DbContext(typeof(AgenciaBusesContext))]
    partial class AgenciaBusesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Buses.Entities.Agencia", b =>
                {
                    b.Property<string>("IdAgencia")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Cpostal")
                        .IsRequired()
                        .HasColumnName("CPostal")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("EstadoAgencia")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NombreAgencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false);

                    b.HasKey("IdAgencia");

                    b.HasIndex("Cpostal");

                    b.ToTable("Agencia");
                });

            modelBuilder.Entity("Buses.Entities.Area", b =>
                {
                    b.Property<string>("IdArea")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("NombreArea")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdArea");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Buses.Entities.AsientoBus", b =>
                {
                    b.Property<string>("IdAsientoBus")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("IdBus")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("NumeroAsiento")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.HasKey("IdAsientoBus");

                    b.HasIndex("IdBus");

                    b.ToTable("AsientoBus");
                });

            modelBuilder.Entity("Buses.Entities.Bus", b =>
                {
                    b.Property<string>("IdBus")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("EstadoBus")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NroPlaca")
                        .IsRequired()
                        .HasMaxLength(7)
                        .IsUnicode(false);

                    b.Property<int>("NumeroAsiento");

                    b.HasKey("IdBus");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("Buses.Entities.Cargo", b =>
                {
                    b.Property<string>("IdCargo")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("IdArea")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("NombreCargo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdCargo");

                    b.HasIndex("IdArea");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Buses.Entities.Departamento", b =>
                {
                    b.Property<string>("IdDepartamento")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdDepartamento");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Buses.Entities.Distrito", b =>
                {
                    b.Property<string>("Cpostal")
                        .HasColumnName("CPostal")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Idprovincia")
                        .IsRequired()
                        .HasColumnName("IDProvincia")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("NombreDistrito")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Cpostal");

                    b.HasIndex("Idprovincia");

                    b.ToTable("Distrito");
                });

            modelBuilder.Entity("Buses.Entities.Empleado", b =>
                {
                    b.Property<string>("IdEmpleado")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("IdArea")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("IdCargo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false);

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdEmpleado");

                    b.HasIndex("IdArea");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Buses.Entities.Facturacion", b =>
                {
                    b.Property<string>("NroFacturacion")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime");

                    b.Property<string>("IdformaPago")
                        .IsRequired()
                        .HasColumnName("IDFormaPago")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<decimal?>("Igv")
                        .HasColumnName("IGV")
                        .HasColumnType("numeric(8, 2)");

                    b.Property<string>("NroPasaje")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<decimal?>("SubTotal")
                        .HasColumnType("numeric(8, 2)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("numeric(8, 2)");

                    b.HasKey("NroFacturacion");

                    b.HasIndex("IdformaPago");

                    b.HasIndex("NroPasaje");

                    b.ToTable("Facturacion");
                });

            modelBuilder.Entity("Buses.Entities.FormaPago", b =>
                {
                    b.Property<string>("IdFormaPago")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("NombreFormaPago")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdFormaPago");

                    b.ToTable("FormaPago");
                });

            modelBuilder.Entity("Buses.Entities.ItinerarioViaje", b =>
                {
                    b.Property<string>("IdItinerario")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("AgenciaDestino")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("AgenciaOrigen")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime>("HoraViaje")
                        .HasColumnType("datetime");

                    b.Property<string>("IdAgencia")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("IdBus")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<decimal?>("PrecioViaje")
                        .HasColumnType("numeric(8, 2)");

                    b.HasKey("IdItinerario");

                    b.HasIndex("IdAgencia");

                    b.HasIndex("IdBus");

                    b.ToTable("ItinerarioViaje");
                });

            modelBuilder.Entity("Buses.Entities.Pasaje", b =>
                {
                    b.Property<string>("NroPasaje")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Estado")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaViaje")
                        .HasColumnType("date");

                    b.Property<string>("IdItinerario")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("IdPasajero")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("NumeroAsieto");

                    b.Property<int>("precioPasaje");

                    b.HasKey("NroPasaje");

                    b.HasIndex("IdItinerario");

                    b.HasIndex("IdPasajero");

                    b.ToTable("Pasaje");
                });

            modelBuilder.Entity("Buses.Entities.Pasajero", b =>
                {
                    b.Property<string>("IdPasajero")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false);

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdPasajero");

                    b.ToTable("Pasajero");
                });

            modelBuilder.Entity("Buses.Entities.Provincia", b =>
                {
                    b.Property<string>("IdProvincia")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("IdDepartamento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("NombreProvincia")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdProvincia");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Buses.Entities.Reserva", b =>
                {
                    b.Property<string>("IdReserva")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Estado")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaLimite")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaReserva")
                        .HasColumnType("date");

                    b.Property<string>("IdEmpleado")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("IdItinerario")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("IdPasajero")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.HasKey("IdReserva");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdItinerario");

                    b.HasIndex("IdPasajero");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Buses.Entities.UsuarioEmpleado", b =>
                {
                    b.Property<string>("IdUsuario")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Idempleado")
                        .HasColumnName("IDEmpleado")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdUsuario");

                    b.HasIndex("Idempleado");

                    b.ToTable("UsuarioEmpleado");
                });

            modelBuilder.Entity("Buses.Entities.UsuarioPasajero", b =>
                {
                    b.Property<string>("IdUsuarioPasajero")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Idpasajero")
                        .HasColumnName("IDPasajero")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdUsuarioPasajero");

                    b.HasIndex("Idpasajero");

                    b.ToTable("UsuarioPasajero");
                });

            modelBuilder.Entity("Buses.Identity.AplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Buses.Identity.AplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Buses.Entities.Agencia", b =>
                {
                    b.HasOne("Buses.Entities.Distrito", "CpostalNavigation")
                        .WithMany("Agencia")
                        .HasForeignKey("Cpostal")
                        .HasConstraintName("FK_AGENCIA_CPOSTAL");
                });

            modelBuilder.Entity("Buses.Entities.AsientoBus", b =>
                {
                    b.HasOne("Buses.Entities.Bus", "IdBusNavigation")
                        .WithMany("AsientoBus")
                        .HasForeignKey("IdBus")
                        .HasConstraintName("FK_ASIENTOBUS_IDBUS");
                });

            modelBuilder.Entity("Buses.Entities.Cargo", b =>
                {
                    b.HasOne("Buses.Entities.Area", "IdAreaNavigation")
                        .WithMany("Cargo")
                        .HasForeignKey("IdArea")
                        .HasConstraintName("FK_CARGO_IDAREA");
                });

            modelBuilder.Entity("Buses.Entities.Distrito", b =>
                {
                    b.HasOne("Buses.Entities.Provincia", "IdprovinciaNavigation")
                        .WithMany("Distrito")
                        .HasForeignKey("Idprovincia")
                        .HasConstraintName("FK_DISTRITO_IDPROVINCIA");
                });

            modelBuilder.Entity("Buses.Entities.Empleado", b =>
                {
                    b.HasOne("Buses.Entities.Area", "IdAreaNavigation")
                        .WithMany("Empleado")
                        .HasForeignKey("IdArea")
                        .HasConstraintName("FK_EMPLEADO_IDAREA");
                });

            modelBuilder.Entity("Buses.Entities.Facturacion", b =>
                {
                    b.HasOne("Buses.Entities.FormaPago", "IdformaPagoNavigation")
                        .WithMany("Facturacion")
                        .HasForeignKey("IdformaPago")
                        .HasConstraintName("FK_FACTURACION_IDFORMAPAGO");

                    b.HasOne("Buses.Entities.Pasaje", "NroPasajeNavigation")
                        .WithMany("Facturacion")
                        .HasForeignKey("NroPasaje")
                        .HasConstraintName("FK_FACTURACION_IDPASAJE");
                });

            modelBuilder.Entity("Buses.Entities.ItinerarioViaje", b =>
                {
                    b.HasOne("Buses.Entities.Agencia", "IdAgenciaNavigation")
                        .WithMany("ItinerarioViaje")
                        .HasForeignKey("IdAgencia")
                        .HasConstraintName("FK_ITINERARIO_VIAJE_IDVIAJE");

                    b.HasOne("Buses.Entities.Bus", "IdBusNavigation")
                        .WithMany("ItinerarioViaje")
                        .HasForeignKey("IdBus")
                        .HasConstraintName("FK_ITINERARIO_VIAJE_IDBUS");
                });

            modelBuilder.Entity("Buses.Entities.Pasaje", b =>
                {
                    b.HasOne("Buses.Entities.ItinerarioViaje", "IdItinerarioNavigation")
                        .WithMany("Pasaje")
                        .HasForeignKey("IdItinerario")
                        .HasConstraintName("FK_PASAJE_IDITINERARIO");

                    b.HasOne("Buses.Entities.Pasajero", "IdPasajeroNavigation")
                        .WithMany("Pasaje")
                        .HasForeignKey("IdPasajero")
                        .HasConstraintName("FK_PASAJE_IDPASAJERO");
                });

            modelBuilder.Entity("Buses.Entities.Provincia", b =>
                {
                    b.HasOne("Buses.Entities.Departamento", "IdDepartamentoNavigation")
                        .WithMany("Provincia")
                        .HasForeignKey("IdDepartamento")
                        .HasConstraintName("FK_PROVINCIA_IDDEPARTAMENTO");
                });

            modelBuilder.Entity("Buses.Entities.Reserva", b =>
                {
                    b.HasOne("Buses.Entities.Empleado", "IdEmpleadoNavigation")
                        .WithMany("Reserva")
                        .HasForeignKey("IdEmpleado")
                        .HasConstraintName("FK_RESERVA_IDEMPLEADO");

                    b.HasOne("Buses.Entities.ItinerarioViaje", "IdItinerarioNavigation")
                        .WithMany("Reserva")
                        .HasForeignKey("IdItinerario")
                        .HasConstraintName("FK_RESERVA_IDITINERARIO");

                    b.HasOne("Buses.Entities.Pasajero", "IdPasajeroNavigation")
                        .WithMany()
                        .HasForeignKey("IdPasajero")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Buses.Entities.UsuarioEmpleado", b =>
                {
                    b.HasOne("Buses.Entities.Empleado", "IdempleadoNavigation")
                        .WithMany("UsuarioEmpleado")
                        .HasForeignKey("Idempleado")
                        .HasConstraintName("FK_USUARIO_EMPLEADO_IDAREA");
                });

            modelBuilder.Entity("Buses.Entities.UsuarioPasajero", b =>
                {
                    b.HasOne("Buses.Entities.Pasajero", "IdpasajeroNavigation")
                        .WithMany("UsuarioPasajero")
                        .HasForeignKey("Idpasajero")
                        .HasConstraintName("FK_USUARIO_PASAJERO_IDPASAJERO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Buses.Identity.AplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Buses.Identity.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Buses.Identity.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Buses.Identity.AplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Buses.Identity.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Buses.Identity.AplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
