﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD2_Travail3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AL_GJ_TravailEntities : DbContext
    {
        public AL_GJ_TravailEntities()
            : base("name=AL_GJ_TravailEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Employe> tbl_Employe { get; set; }
        public virtual DbSet<tbl_Impute> tbl_Impute { get; set; }
        public virtual DbSet<tbl_Inventaire> tbl_Inventaire { get; set; }
        public virtual DbSet<tbl_Marque> tbl_Marque { get; set; }
        public virtual DbSet<tbl_Projet> tbl_Projet { get; set; }
    
        public virtual int Imputation(Nullable<int> no_Employe, Nullable<int> no_Piece, Nullable<int> no_Projet, Nullable<System.DateTime> date, Nullable<int> quantite_Retire)
        {
            var no_EmployeParameter = no_Employe.HasValue ?
                new ObjectParameter("no_Employe", no_Employe) :
                new ObjectParameter("no_Employe", typeof(int));
    
            var no_PieceParameter = no_Piece.HasValue ?
                new ObjectParameter("no_Piece", no_Piece) :
                new ObjectParameter("no_Piece", typeof(int));
    
            var no_ProjetParameter = no_Projet.HasValue ?
                new ObjectParameter("no_Projet", no_Projet) :
                new ObjectParameter("no_Projet", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var quantite_RetireParameter = quantite_Retire.HasValue ?
                new ObjectParameter("quantite_Retire", quantite_Retire) :
                new ObjectParameter("quantite_Retire", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Imputation", no_EmployeParameter, no_PieceParameter, no_ProjetParameter, dateParameter, quantite_RetireParameter);
        }
    
        public virtual ObjectResult<RecherchePieceParNoPiece_Result> RecherchePieceParNoPiece(string noPieceDemandé)
        {
            var noPieceDemandéParameter = noPieceDemandé != null ?
                new ObjectParameter("noPieceDemandé", noPieceDemandé) :
                new ObjectParameter("noPieceDemandé", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RecherchePieceParNoPiece_Result>("RecherchePieceParNoPiece", noPieceDemandéParameter);
        }
    
        public virtual ObjectResult<selectionnerEmployeSelonRecherche_Result> selectionnerEmployeSelonRecherche(string searchTerm)
        {
            var searchTermParameter = searchTerm != null ?
                new ObjectParameter("searchTerm", searchTerm) :
                new ObjectParameter("searchTerm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectionnerEmployeSelonRecherche_Result>("selectionnerEmployeSelonRecherche", searchTermParameter);
        }
    
        public virtual ObjectResult<selectionnerTouteLesEmployes_Result> selectionnerTouteLesEmployes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectionnerTouteLesEmployes_Result>("selectionnerTouteLesEmployes");
        }
    
        public virtual int SuppressionDobjetDeLInventaire(Nullable<int> quantiteAEnlever, Nullable<int> no_Piece)
        {
            var quantiteAEnleverParameter = quantiteAEnlever.HasValue ?
                new ObjectParameter("QuantiteAEnlever", quantiteAEnlever) :
                new ObjectParameter("QuantiteAEnlever", typeof(int));
    
            var no_PieceParameter = no_Piece.HasValue ?
                new ObjectParameter("no_Piece", no_Piece) :
                new ObjectParameter("no_Piece", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuppressionDobjetDeLInventaire", quantiteAEnleverParameter, no_PieceParameter);
        }
    
        public virtual ObjectResult<getImputeByYearAndMonth_Result1> getImputeByYearAndMonth(Nullable<int> no_Piece, string yearSearchTerm)
        {
            var no_PieceParameter = no_Piece.HasValue ?
                new ObjectParameter("no_Piece", no_Piece) :
                new ObjectParameter("no_Piece", typeof(int));
    
            var yearSearchTermParameter = yearSearchTerm != null ?
                new ObjectParameter("yearSearchTerm", yearSearchTerm) :
                new ObjectParameter("yearSearchTerm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getImputeByYearAndMonth_Result1>("getImputeByYearAndMonth", no_PieceParameter, yearSearchTermParameter);
        }
    }
}