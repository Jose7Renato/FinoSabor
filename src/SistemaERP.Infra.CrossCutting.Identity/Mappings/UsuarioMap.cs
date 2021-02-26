﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaERP.Infra.CrossCutting.Identity.Entities;

namespace SistemaERP.Infra.CrossCutting.Identity.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Ignore(c => c.PhoneNumber);

            builder
                .HasMany(e => e.Logins)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder
                .HasMany(e => e.UsuarioFuncao)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder
                .HasMany(e => e.Tokens)
                .WithOne()
                .HasForeignKey(ut => ut.UserId)
                .IsRequired();

            builder.ToTable("Usuario");

        }
    }
}
