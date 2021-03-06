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
    [Migration("20171001080630_Initial")]
    partial class Initial
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

                    b.HasKey("CompetitionId");

                    b.ToTable("Competitions","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.CompetitionInstance", b =>
                {
                    b.Property<int>("CompetitionInstanceId");

                    b.Property<int>("CompetitionId");

                    b.Property<int>("SeasonId");

                    b.HasKey("CompetitionInstanceId");

                    b.ToTable("CompetitionInstances","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.CompetitionParticipation", b =>
                {
                    b.Property<int>("CompetitionParticipationId");

                    b.Property<int>("CompetitionInstanceId");

                    b.Property<int>("TeamId");

                    b.HasKey("CompetitionParticipationId");

                    b.ToTable("TeamParticipations");
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

                    b.ToTable("Season","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("TeamId");

                    b.ToTable("Teams","XG");
                });

            modelBuilder.Entity("XG.Data.Entities.CompetitionInstance", b =>
                {
                    b.HasOne("XG.Data.Entities.Competition", "Competition")
                        .WithMany("CompetitionInstances")
                        .HasForeignKey("CompetitionInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("XG.Data.Entities.Season", "Season")
                        .WithMany("CompetitionInstances")
                        .HasForeignKey("CompetitionInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XG.Data.Entities.CompetitionParticipation", b =>
                {
                    b.HasOne("XG.Data.Entities.CompetitionInstance", "CompetitionInstance")
                        .WithMany("TeamsTakingPart")
                        .HasForeignKey("CompetitionParticipationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("XG.Data.Entities.Team", "Team")
                        .WithMany("CompetitionParticipations")
                        .HasForeignKey("CompetitionParticipationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
