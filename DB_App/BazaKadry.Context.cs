﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_App
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class kadryEntities2 : DbContext
    {
        public kadryEntities2()
            : base("name=kadryEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AppUsers> AppUsers { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Dzialy> Dzialy { get; set; }
        public virtual DbSet<Oferty> Oferty { get; set; }
        public virtual DbSet<Podania> Podania { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Rozmowy> Rozmowy { get; set; }
        public virtual DbSet<stan_dzial> stan_dzial { get; set; }
        public virtual DbSet<Stanowiska> Stanowiska { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TABELE> TABELE { get; set; }
        public virtual DbSet<kierownicy1> kierownicy1 { get; set; }
        public virtual DbSet<PracDzial> PracDzials { get; set; }
        public virtual DbSet<WolneEt> WolneEts { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int ModAppUsers(Nullable<int> nidPo, string login, string pass, string role)
        {
            var nidPoParameter = nidPo.HasValue ?
                new ObjectParameter("NidPo", nidPo) :
                new ObjectParameter("NidPo", typeof(int));
    
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModAppUsers", nidPoParameter, loginParameter, passParameter, roleParameter);
        }
    
        public virtual int ModDzialy(Nullable<int> nidPo, string nimiePo, string nmiasto, string nadres)
        {
            var nidPoParameter = nidPo.HasValue ?
                new ObjectParameter("NidPo", nidPo) :
                new ObjectParameter("NidPo", typeof(int));
    
            var nimiePoParameter = nimiePo != null ?
                new ObjectParameter("NimiePo", nimiePo) :
                new ObjectParameter("NimiePo", typeof(string));
    
            var nmiastoParameter = nmiasto != null ?
                new ObjectParameter("Nmiasto", nmiasto) :
                new ObjectParameter("Nmiasto", typeof(string));
    
            var nadresParameter = nadres != null ?
                new ObjectParameter("Nadres", nadres) :
                new ObjectParameter("Nadres", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModDzialy", nidPoParameter, nimiePoParameter, nmiastoParameter, nadresParameter);
        }
    
        public virtual int ModOferty(Nullable<int> nO, Nullable<System.DateTime> data)
        {
            var nOParameter = nO.HasValue ?
                new ObjectParameter("NO", nO) :
                new ObjectParameter("NO", typeof(int));
    
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModOferty", nOParameter, dataParameter);
        }
    
        public virtual int ModPodania(Nullable<int> nidPo, Nullable<int> nidR, Nullable<int> nidO, string nimiePo, string nnazwisko, string nmiasto, string nadres, Nullable<System.DateTime> ndataUr, string wyksz, Nullable<System.DateTime> ndataZl)
        {
            var nidPoParameter = nidPo.HasValue ?
                new ObjectParameter("NidPo", nidPo) :
                new ObjectParameter("NidPo", typeof(int));
    
            var nidRParameter = nidR.HasValue ?
                new ObjectParameter("NidR", nidR) :
                new ObjectParameter("NidR", typeof(int));
    
            var nidOParameter = nidO.HasValue ?
                new ObjectParameter("NidO", nidO) :
                new ObjectParameter("NidO", typeof(int));
    
            var nimiePoParameter = nimiePo != null ?
                new ObjectParameter("NimiePo", nimiePo) :
                new ObjectParameter("NimiePo", typeof(string));
    
            var nnazwiskoParameter = nnazwisko != null ?
                new ObjectParameter("nnazwisko", nnazwisko) :
                new ObjectParameter("nnazwisko", typeof(string));
    
            var nmiastoParameter = nmiasto != null ?
                new ObjectParameter("Nmiasto", nmiasto) :
                new ObjectParameter("Nmiasto", typeof(string));
    
            var nadresParameter = nadres != null ?
                new ObjectParameter("Nadres", nadres) :
                new ObjectParameter("Nadres", typeof(string));
    
            var ndataUrParameter = ndataUr.HasValue ?
                new ObjectParameter("NdataUr", ndataUr) :
                new ObjectParameter("NdataUr", typeof(System.DateTime));
    
            var wykszParameter = wyksz != null ?
                new ObjectParameter("Wyksz", wyksz) :
                new ObjectParameter("Wyksz", typeof(string));
    
            var ndataZlParameter = ndataZl.HasValue ?
                new ObjectParameter("NdataZl", ndataZl) :
                new ObjectParameter("NdataZl", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModPodania", nidPoParameter, nidRParameter, nidOParameter, nimiePoParameter, nnazwiskoParameter, nmiastoParameter, nadresParameter, ndataUrParameter, wykszParameter, ndataZlParameter);
        }
    
        public virtual int ModPrac_dzial(Nullable<int> nO, Nullable<int> nS)
        {
            var nOParameter = nO.HasValue ?
                new ObjectParameter("NO", nO) :
                new ObjectParameter("NO", typeof(int));
    
            var nSParameter = nS.HasValue ?
                new ObjectParameter("NS", nS) :
                new ObjectParameter("NS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModPrac_dzial", nOParameter, nSParameter);
        }
    
        public virtual int ModPracownicy(Nullable<int> nidPo, string nimiePo, string nnazwisko, string nmiasto, string nadres, string wyksz, Nullable<double> ndataZl)
        {
            var nidPoParameter = nidPo.HasValue ?
                new ObjectParameter("NidPo", nidPo) :
                new ObjectParameter("NidPo", typeof(int));
    
            var nimiePoParameter = nimiePo != null ?
                new ObjectParameter("NimiePo", nimiePo) :
                new ObjectParameter("NimiePo", typeof(string));
    
            var nnazwiskoParameter = nnazwisko != null ?
                new ObjectParameter("nnazwisko", nnazwisko) :
                new ObjectParameter("nnazwisko", typeof(string));
    
            var nmiastoParameter = nmiasto != null ?
                new ObjectParameter("Nmiasto", nmiasto) :
                new ObjectParameter("Nmiasto", typeof(string));
    
            var nadresParameter = nadres != null ?
                new ObjectParameter("Nadres", nadres) :
                new ObjectParameter("Nadres", typeof(string));
    
            var wykszParameter = wyksz != null ?
                new ObjectParameter("Wyksz", wyksz) :
                new ObjectParameter("Wyksz", typeof(string));
    
            var ndataZlParameter = ndataZl.HasValue ?
                new ObjectParameter("NdataZl", ndataZl) :
                new ObjectParameter("NdataZl", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModPracownicy", nidPoParameter, nimiePoParameter, nnazwiskoParameter, nmiastoParameter, nadresParameter, wykszParameter, ndataZlParameter);
        }
    
        public virtual int ModRozmowy(Nullable<int> nidPo, Nullable<int> nP, Nullable<int> nR, Nullable<System.DateTime> nimiePo)
        {
            var nidPoParameter = nidPo.HasValue ?
                new ObjectParameter("NidPo", nidPo) :
                new ObjectParameter("NidPo", typeof(int));
    
            var nPParameter = nP.HasValue ?
                new ObjectParameter("NP", nP) :
                new ObjectParameter("NP", typeof(int));
    
            var nRParameter = nR.HasValue ?
                new ObjectParameter("NR", nR) :
                new ObjectParameter("NR", typeof(int));
    
            var nimiePoParameter = nimiePo.HasValue ?
                new ObjectParameter("NimiePo", nimiePo) :
                new ObjectParameter("NimiePo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModRozmowy", nidPoParameter, nPParameter, nRParameter, nimiePoParameter);
        }
    
        public virtual int ModStanDzial(Nullable<int> nO, Nullable<int> nS)
        {
            var nOParameter = nO.HasValue ?
                new ObjectParameter("NO", nO) :
                new ObjectParameter("NO", typeof(int));
    
            var nSParameter = nS.HasValue ?
                new ObjectParameter("NS", nS) :
                new ObjectParameter("NS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModStanDzial", nOParameter, nSParameter);
        }
    
        public virtual int ModStano(Nullable<int> nidPo, string nimiePo)
        {
            var nidPoParameter = nidPo.HasValue ?
                new ObjectParameter("NidPo", nidPo) :
                new ObjectParameter("NidPo", typeof(int));
    
            var nimiePoParameter = nimiePo != null ?
                new ObjectParameter("NimiePo", nimiePo) :
                new ObjectParameter("NimiePo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModStano", nidPoParameter, nimiePoParameter);
        }
    
        public virtual int ModStanPrac(Nullable<int> nO, Nullable<int> nS)
        {
            var nOParameter = nO.HasValue ?
                new ObjectParameter("NO", nO) :
                new ObjectParameter("NO", typeof(int));
    
            var nSParameter = nS.HasValue ?
                new ObjectParameter("NS", nS) :
                new ObjectParameter("NS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModStanPrac", nOParameter, nSParameter);
        }
    
        public virtual int AppUsDel(Nullable<int> idD)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AppUsDel", idDParameter);
        }
    
        public virtual int DelDzial(Nullable<int> idD)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DelDzial", idDParameter);
        }
    
        public virtual int OfertyDel(Nullable<int> idD)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OfertyDel", idDParameter);
        }
    
        public virtual int PodaniaDel(Nullable<int> idD)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PodaniaDel", idDParameter);
        }
    
        public virtual int PracowDel(Nullable<int> idD)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PracowDel", idDParameter);
        }
    
        public virtual int RozmowyDel(Nullable<int> idD)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RozmowyDel", idDParameter);
        }
    
        public virtual int StanDel(Nullable<int> id1)
        {
            var id1Parameter = id1.HasValue ?
                new ObjectParameter("id1", id1) :
                new ObjectParameter("id1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StanDel", id1Parameter);
        }
    
        public virtual int StanDzial(Nullable<int> id1, Nullable<int> id2)
        {
            var id1Parameter = id1.HasValue ?
                new ObjectParameter("id1", id1) :
                new ObjectParameter("id1", typeof(int));
    
            var id2Parameter = id2.HasValue ?
                new ObjectParameter("id2", id2) :
                new ObjectParameter("id2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StanDzial", id1Parameter, id2Parameter);
        }
    
        public virtual int StanDzialDel(Nullable<int> id1, Nullable<int> id2)
        {
            var id1Parameter = id1.HasValue ?
                new ObjectParameter("id1", id1) :
                new ObjectParameter("id1", typeof(int));
    
            var id2Parameter = id2.HasValue ?
                new ObjectParameter("id2", id2) :
                new ObjectParameter("id2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StanDzialDel", id1Parameter, id2Parameter);
        }
    
        public virtual ObjectResult<kierownicy_Result> kierownicy()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<kierownicy_Result>("kierownicy");
        }
    
        public virtual ObjectResult<pracownicyDzialu_Result> pracownicyDzialu(Nullable<int> idDzialu)
        {
            var idDzialuParameter = idDzialu.HasValue ?
                new ObjectParameter("idDzialu", idDzialu) :
                new ObjectParameter("idDzialu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pracownicyDzialu_Result>("pracownicyDzialu", idDzialuParameter);
        }
    
        public virtual ObjectResult<WolneEtaty_Result> WolneEtaty()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WolneEtaty_Result>("WolneEtaty");
        }
    
        public virtual ObjectResult<rozmowyPerDzien_Result> rozmowyPerDzien(Nullable<System.DateTime> data)
        {
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rozmowyPerDzien_Result>("rozmowyPerDzien", dataParameter);
        }
    
        public virtual int AddPracMore(Nullable<int> idD, Nullable<int> idP, Nullable<int> idS)
        {
            var idDParameter = idD.HasValue ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(int));
    
            var idPParameter = idP.HasValue ?
                new ObjectParameter("idP", idP) :
                new ObjectParameter("idP", typeof(int));
    
            var idSParameter = idS.HasValue ?
                new ObjectParameter("idS", idS) :
                new ObjectParameter("idS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPracMore", idDParameter, idPParameter, idSParameter);
        }
    }
}
