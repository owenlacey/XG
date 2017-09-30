﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using XG.Data;

namespace XG.Data.Migrations
{
    [DbContext(typeof(XgContext))]
    [Migration("20170930083107_IncludeMappings")]
    partial class IncludeMappings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("XG")
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XG.Data.Entities.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SeasonId");

                    b.HasKey("CompetitionId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Competitions","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("MatchId");

                    b.ToTable("Matches","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.Competition", b =>
                {
                    b.HasOne("XG.Data.Entities.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
