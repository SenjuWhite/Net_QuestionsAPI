﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questions_NET.DataAccess;

#nullable disable

namespace Questions_NET.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240410104836_dbsetup")]
    partial class dbsetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Net_QuestionsAPI.Models.Interview", b =>
                {
                    b.Property<int>("InterviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterviewId"));

                    b.Property<int>("InterviewLevel")
                        .HasColumnType("int");

                    b.Property<string>("InterviewLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterviewId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("Net_QuestionsAPI.Models.InterviewQuestion", b =>
                {
                    b.Property<int>("IntQuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IntQuestId"));

                    b.Property<int>("InterviewId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("Timecode")
                        .HasColumnType("int");

                    b.HasKey("IntQuestId");

                    b.HasIndex("InterviewId");

                    b.HasIndex("QuestionId");

                    b.ToTable("InterviewsQuestions");
                });

            modelBuilder.Entity("Net_QuestionsAPI.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("QuestionAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Net_QuestionsAPI.Models.QuestionLink", b =>
                {
                    b.Property<int>("QuestionLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionLinkId"));

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("QuestionLinkId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionLinks");
                });

            modelBuilder.Entity("Net_QuestionsAPI.Models.InterviewQuestion", b =>
                {
                    b.HasOne("Net_QuestionsAPI.Models.Interview", "Interview")
                        .WithMany()
                        .HasForeignKey("InterviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net_QuestionsAPI.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interview");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Net_QuestionsAPI.Models.QuestionLink", b =>
                {
                    b.HasOne("Net_QuestionsAPI.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });
#pragma warning restore 612, 618
        }
    }
}
