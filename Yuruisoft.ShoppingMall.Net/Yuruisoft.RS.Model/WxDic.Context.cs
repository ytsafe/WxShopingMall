﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yuruisoft.RS.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WxDicEntities : DbContext
    {
        public WxDicEntities()
            : base("name=WxDicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<WxDic_Dictionary> WxDic_Dictionary { get; set; }
        public DbSet<WxDic_EnToCn_A_b> WxDic_EnToCn_A_b { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_b> WxDic_SearchKey_EnToCn_A_b { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_c> WxDic_SearchKey_EnToCn_A_c { get; set; }
        public DbSet<WxDic_EnToCn_A_c> WxDic_EnToCn_A_c { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_d> WxDic_SearchKey_EnToCn_A_d { get; set; }
        public DbSet<WxDic_EnToCn_A_d> WxDic_EnToCn_A_d { get; set; }
        public DbSet<WxDic_EnToCn_A_e> WxDic_EnToCn_A_e { get; set; }
        public DbSet<WxDic_EnToCn_A_f> WxDic_EnToCn_A_f { get; set; }
        public DbSet<WxDic_EnToCn_A_g> WxDic_EnToCn_A_g { get; set; }
        public DbSet<WxDic_EnToCn_A_h> WxDic_EnToCn_A_h { get; set; }
        public DbSet<WxDic_EnToCn_A_ijk> WxDic_EnToCn_A_ijk { get; set; }
        public DbSet<WxDic_EnToCn_A_l> WxDic_EnToCn_A_l { get; set; }
        public DbSet<WxDic_EnToCn_A_m> WxDic_EnToCn_A_m { get; set; }
        public DbSet<WxDic_EnToCn_A_n> WxDic_EnToCn_A_n { get; set; }
        public DbSet<WxDic_EnToCn_A_op> WxDic_EnToCn_A_op { get; set; }
        public DbSet<WxDic_EnToCn_A_qr> WxDic_EnToCn_A_qr { get; set; }
        public DbSet<WxDic_EnToCn_A_s> WxDic_EnToCn_A_s { get; set; }
        public DbSet<WxDic_EnToCn_A_t> WxDic_EnToCn_A_t { get; set; }
        public DbSet<WxDic_EnToCn_A_uvwxyz> WxDic_EnToCn_A_uvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_e> WxDic_SearchKey_EnToCn_A_e { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_f> WxDic_SearchKey_EnToCn_A_f { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_g> WxDic_SearchKey_EnToCn_A_g { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_h> WxDic_SearchKey_EnToCn_A_h { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_ijk> WxDic_SearchKey_EnToCn_A_ijk { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_l> WxDic_SearchKey_EnToCn_A_l { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_m> WxDic_SearchKey_EnToCn_A_m { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_n> WxDic_SearchKey_EnToCn_A_n { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_op> WxDic_SearchKey_EnToCn_A_op { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_qr> WxDic_SearchKey_EnToCn_A_qr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_s> WxDic_SearchKey_EnToCn_A_s { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_t> WxDic_SearchKey_EnToCn_A_t { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_A_uvwxyz> WxDic_SearchKey_EnToCn_A_uvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_B_a> WxDic_EnToCn_B_a { get; set; }
        public DbSet<WxDic_EnToCn_B_bcde> WxDic_EnToCn_B_bcde { get; set; }
        public DbSet<WxDic_EnToCn_B_fghi> WxDic_EnToCn_B_fghi { get; set; }
        public DbSet<WxDic_EnToCn_B_jklmn> WxDic_EnToCn_B_jklmn { get; set; }
        public DbSet<WxDic_EnToCn_B_o> WxDic_EnToCn_B_o { get; set; }
        public DbSet<WxDic_EnToCn_B_pqr> WxDic_EnToCn_B_pqr { get; set; }
        public DbSet<WxDic_EnToCn_B_stu> WxDic_EnToCn_B_stu { get; set; }
        public DbSet<WxDic_EnToCn_B_vwxyz> WxDic_EnToCn_B_vwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_a> WxDic_SearchKey_EnToCn_B_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_bcde> WxDic_SearchKey_EnToCn_B_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_fghi> WxDic_SearchKey_EnToCn_B_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_jklmn> WxDic_SearchKey_EnToCn_B_jklmn { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_o> WxDic_SearchKey_EnToCn_B_o { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_pqr> WxDic_SearchKey_EnToCn_B_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_stu> WxDic_SearchKey_EnToCn_B_stu { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_B_vwxyz> WxDic_SearchKey_EnToCn_B_vwxyz { get; set; }
        public DbSet<WxDic_EnToCn_B_stuvwxyz> WxDic_EnToCn_B_stuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_C_a> WxDic_EnToCn_C_a { get; set; }
        public DbSet<WxDic_EnToCn_C_bcdefg> WxDic_EnToCn_C_bcdefg { get; set; }
        public DbSet<WxDic_EnToCn_C_h> WxDic_EnToCn_C_h { get; set; }
        public DbSet<WxDic_EnToCn_C_ijk> WxDic_EnToCn_C_ijk { get; set; }
        public DbSet<WxDic_EnToCn_C_lmn> WxDic_EnToCn_C_lmn { get; set; }
        public DbSet<WxDic_EnToCn_C_o> WxDic_EnToCn_C_o { get; set; }
        public DbSet<WxDic_EnToCn_C_pqr> WxDic_EnToCn_C_pqr { get; set; }
        public DbSet<WxDic_EnToCn_D_a> WxDic_EnToCn_D_a { get; set; }
        public DbSet<WxDic_EnToCn_D_bcde> WxDic_EnToCn_D_bcde { get; set; }
        public DbSet<WxDic_EnToCn_D_i> WxDic_EnToCn_D_i { get; set; }
        public DbSet<WxDic_EnToCn_D_jklmno> WxDic_EnToCn_D_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_D_pqr> WxDic_EnToCn_D_pqr { get; set; }
        public DbSet<WxDic_EnToCn_D_stuvwxyz> WxDic_EnToCn_D_stuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_E_a> WxDic_EnToCn_E_a { get; set; }
        public DbSet<WxDic_EnToCn_E_bc> WxDic_EnToCn_E_bc { get; set; }
        public DbSet<WxDic_EnToCn_E_defg> WxDic_EnToCn_E_defg { get; set; }
        public DbSet<WxDic_EnToCn_E_hijkl> WxDic_EnToCn_E_hijkl { get; set; }
        public DbSet<WxDic_EnToCn_E_m> WxDic_EnToCn_E_m { get; set; }
        public DbSet<WxDic_EnToCn_E_n> WxDic_EnToCn_E_n { get; set; }
        public DbSet<WxDic_EnToCn_E_opq> WxDic_EnToCn_E_opq { get; set; }
        public DbSet<WxDic_EnToCn_E_rs> WxDic_EnToCn_E_rs { get; set; }
        public DbSet<WxDic_EnToCn_E_tuvw> WxDic_EnToCn_E_tuvw { get; set; }
        public DbSet<WxDic_EnToCn_E_xyz> WxDic_EnToCn_E_xyz { get; set; }
        public DbSet<WxDic_EnToCn_F_a> WxDic_EnToCn_F_a { get; set; }
        public DbSet<WxDic_EnToCn_F_bcde> WxDic_EnToCn_F_bcde { get; set; }
        public DbSet<WxDic_EnToCn_F_fghi> WxDic_EnToCn_F_fghi { get; set; }
        public DbSet<WxDic_EnToCn_F_jkl> WxDic_EnToCn_F_jkl { get; set; }
        public DbSet<WxDic_EnToCn_F_mno> WxDic_EnToCn_F_mno { get; set; }
        public DbSet<WxDic_EnToCn_F_pqr> WxDic_EnToCn_F_pqr { get; set; }
        public DbSet<WxDic_EnToCn_F_stuvwvxyz> WxDic_EnToCn_F_stuvwvxyz { get; set; }
        public DbSet<WxDic_EnToCn_G_a> WxDic_EnToCn_G_a { get; set; }
        public DbSet<WxDic_EnToCn_G_bcde> WxDic_EnToCn_G_bcde { get; set; }
        public DbSet<WxDic_EnToCn_G_fghi> WxDic_EnToCn_G_fghi { get; set; }
        public DbSet<WxDic_EnToCn_G_jkl> WxDic_EnToCn_G_jkl { get; set; }
        public DbSet<WxDic_EnToCn_G_mno> WxDic_EnToCn_G_mno { get; set; }
        public DbSet<WxDic_EnToCn_G_pqr> WxDic_EnToCn_G_pqr { get; set; }
        public DbSet<WxDic_EnToCn_G_stuvwvxyz> WxDic_EnToCn_G_stuvwvxyz { get; set; }
        public DbSet<WxDic_EnToCn_H_a> WxDic_EnToCn_H_a { get; set; }
        public DbSet<WxDic_EnToCn_H_bcde> WxDic_EnToCn_H_bcde { get; set; }
        public DbSet<WxDic_EnToCn_H_fghi> WxDic_EnToCn_H_fghi { get; set; }
        public DbSet<WxDic_EnToCn_H_jklmno> WxDic_EnToCn_H_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_H_pqrstuvwxyz> WxDic_EnToCn_H_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_I_abcd> WxDic_EnToCn_I_abcd { get; set; }
        public DbSet<WxDic_EnToCn_I_efghijklm> WxDic_EnToCn_I_efghijklm { get; set; }
        public DbSet<WxDic_EnToCn_I_n> WxDic_EnToCn_I_n { get; set; }
        public DbSet<WxDic_EnToCn_I_opqrstuvwxyz> WxDic_EnToCn_I_opqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_J> WxDic_EnToCn_J { get; set; }
        public DbSet<WxDic_EnToCn_K> WxDic_EnToCn_K { get; set; }
        public DbSet<WxDic_EnToCn_L_a> WxDic_EnToCn_L_a { get; set; }
        public DbSet<WxDic_EnToCn_L_bcde> WxDic_EnToCn_L_bcde { get; set; }
        public DbSet<WxDic_EnToCn_L_fghi> WxDic_EnToCn_L_fghi { get; set; }
        public DbSet<WxDic_EnToCn_L_jklmno> WxDic_EnToCn_L_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_L_pqrstuvwxyz> WxDic_EnToCn_L_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_M_a> WxDic_EnToCn_M_a { get; set; }
        public DbSet<WxDic_EnToCn_M_bcde> WxDic_EnToCn_M_bcde { get; set; }
        public DbSet<WxDic_EnToCn_M_fghi> WxDic_EnToCn_M_fghi { get; set; }
        public DbSet<WxDic_EnToCn_M_jklmno> WxDic_EnToCn_M_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_M_pqrstuvwxyz> WxDic_EnToCn_M_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_N_a> WxDic_EnToCn_N_a { get; set; }
        public DbSet<WxDic_EnToCn_N_bcde> WxDic_EnToCn_N_bcde { get; set; }
        public DbSet<WxDic_EnToCn_N_fghi> WxDic_EnToCn_N_fghi { get; set; }
        public DbSet<WxDic_EnToCn_N_jklmno> WxDic_EnToCn_N_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_N_pqrstuvwxyz> WxDic_EnToCn_N_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_O_ab> WxDic_EnToCn_O_ab { get; set; }
        public DbSet<WxDic_EnToCn_O_cdef> WxDic_EnToCn_O_cdef { get; set; }
        public DbSet<WxDic_EnToCn_O_ghijklmn> WxDic_EnToCn_O_ghijklmn { get; set; }
        public DbSet<WxDic_EnToCn_O_op> WxDic_EnToCn_O_op { get; set; }
        public DbSet<WxDic_EnToCn_O_qr> WxDic_EnToCn_O_qr { get; set; }
        public DbSet<WxDic_EnToCn_O_stu> WxDic_EnToCn_O_stu { get; set; }
        public DbSet<WxDic_EnToCn_O_vwvxyz> WxDic_EnToCn_O_vwvxyz { get; set; }
        public DbSet<WxDic_EnToCn_P_a> WxDic_EnToCn_P_a { get; set; }
        public DbSet<WxDic_EnToCn_P_bcde> WxDic_EnToCn_P_bcde { get; set; }
        public DbSet<WxDic_EnToCn_P_fgh> WxDic_EnToCn_P_fgh { get; set; }
        public DbSet<WxDic_EnToCn_P_i> WxDic_EnToCn_P_i { get; set; }
        public DbSet<WxDic_EnToCn_P_jkl> WxDic_EnToCn_P_jkl { get; set; }
        public DbSet<WxDic_EnToCn_P_mno> WxDic_EnToCn_P_mno { get; set; }
        public DbSet<WxDic_EnToCn_P_pqr> WxDic_EnToCn_P_pqr { get; set; }
        public DbSet<WxDic_EnToCn_P_stuvwxyz> WxDic_EnToCn_P_stuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_Q> WxDic_EnToCn_Q { get; set; }
        public DbSet<WxDic_EnToCn_R_a> WxDic_EnToCn_R_a { get; set; }
        public DbSet<WxDic_EnToCn_R_bcde> WxDic_EnToCn_R_bcde { get; set; }
        public DbSet<WxDic_EnToCn_R_fghi> WxDic_EnToCn_R_fghi { get; set; }
        public DbSet<WxDic_EnToCn_R_jklmno> WxDic_EnToCn_R_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_R_pqrstuvwxyz> WxDic_EnToCn_R_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_S_a> WxDic_EnToCn_S_a { get; set; }
        public DbSet<WxDic_EnToCn_S_bc> WxDic_EnToCn_S_bc { get; set; }
        public DbSet<WxDic_EnToCn_S_de> WxDic_EnToCn_S_de { get; set; }
        public DbSet<WxDic_EnToCn_S_fgh> WxDic_EnToCn_S_fgh { get; set; }
        public DbSet<WxDic_EnToCn_S_i> WxDic_EnToCn_S_i { get; set; }
        public DbSet<WxDic_EnToCn_S_jk> WxDic_EnToCn_S_jk { get; set; }
        public DbSet<WxDic_EnToCn_S_l> WxDic_EnToCn_S_l { get; set; }
        public DbSet<WxDic_EnToCn_S_mn> WxDic_EnToCn_S_mn { get; set; }
        public DbSet<WxDic_EnToCn_S_o> WxDic_EnToCn_S_o { get; set; }
        public DbSet<WxDic_EnToCn_S_p> WxDic_EnToCn_S_p { get; set; }
        public DbSet<WxDic_EnToCn_S_qst> WxDic_EnToCn_S_qst { get; set; }
        public DbSet<WxDic_EnToCn_S_u> WxDic_EnToCn_S_u { get; set; }
        public DbSet<WxDic_EnToCn_S_vwxyz> WxDic_EnToCn_S_vwxyz { get; set; }
        public DbSet<WxDic_EnToCn_T_a> WxDic_EnToCn_T_a { get; set; }
        public DbSet<WxDic_EnToCn_T_bcde> WxDic_EnToCn_T_bcde { get; set; }
        public DbSet<WxDic_EnToCn_T_fgh> WxDic_EnToCn_T_fgh { get; set; }
        public DbSet<WxDic_EnToCn_T_i> WxDic_EnToCn_T_i { get; set; }
        public DbSet<WxDic_EnToCn_T_o> WxDic_EnToCn_T_o { get; set; }
        public DbSet<WxDic_EnToCn_T_pqr> WxDic_EnToCn_T_pqr { get; set; }
        public DbSet<WxDic_EnToCn_T_stu> WxDic_EnToCn_T_stu { get; set; }
        public DbSet<WxDic_EnToCn_T_vwxyz> WxDic_EnToCn_T_vwxyz { get; set; }
        public DbSet<WxDic_EnToCn_U_abcdefghijklmn> WxDic_EnToCn_U_abcdefghijklmn { get; set; }
        public DbSet<WxDic_EnToCn_U_opqrstuvwxyz> WxDic_EnToCn_U_opqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_V_a> WxDic_EnToCn_V_a { get; set; }
        public DbSet<WxDic_EnToCn_V_bcde> WxDic_EnToCn_V_bcde { get; set; }
        public DbSet<WxDic_EnToCn_V_fghi> WxDic_EnToCn_V_fghi { get; set; }
        public DbSet<WxDic_EnToCn_V_jklmnopqrstuvwxyz> WxDic_EnToCn_V_jklmnopqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_W_a> WxDic_EnToCn_W_a { get; set; }
        public DbSet<WxDic_EnToCn_W_bcde> WxDic_EnToCn_W_bcde { get; set; }
        public DbSet<WxDic_EnToCn_W_fgh> WxDic_EnToCn_W_fgh { get; set; }
        public DbSet<WxDic_EnToCn_W_i> WxDic_EnToCn_W_i { get; set; }
        public DbSet<WxDic_EnToCn_W_jklmno> WxDic_EnToCn_W_jklmno { get; set; }
        public DbSet<WxDic_EnToCn_W_pqrstuvwxyz> WxDic_EnToCn_W_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_X> WxDic_EnToCn_X { get; set; }
        public DbSet<WxDic_EnToCn_Y> WxDic_EnToCn_Y { get; set; }
        public DbSet<WxDic_EnToCn_Z> WxDic_EnToCn_Z { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_a> WxDic_SearchKey_EnToCn_C_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_bcdefg> WxDic_SearchKey_EnToCn_C_bcdefg { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_h> WxDic_SearchKey_EnToCn_C_h { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_ijk> WxDic_SearchKey_EnToCn_C_ijk { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_lmn> WxDic_SearchKey_EnToCn_C_lmn { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_o> WxDic_SearchKey_EnToCn_C_o { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_pqr> WxDic_SearchKey_EnToCn_C_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_C_stuvwxyz> WxDic_SearchKey_EnToCn_C_stuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_D_a> WxDic_SearchKey_EnToCn_D_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_D_bcde> WxDic_SearchKey_EnToCn_D_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_D_i> WxDic_SearchKey_EnToCn_D_i { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_D_jklmno> WxDic_SearchKey_EnToCn_D_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_D_pqr> WxDic_SearchKey_EnToCn_D_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_D_stuvwxyz> WxDic_SearchKey_EnToCn_D_stuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_a> WxDic_SearchKey_EnToCn_E_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_bc> WxDic_SearchKey_EnToCn_E_bc { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_defg> WxDic_SearchKey_EnToCn_E_defg { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_hijkl> WxDic_SearchKey_EnToCn_E_hijkl { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_m> WxDic_SearchKey_EnToCn_E_m { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_n> WxDic_SearchKey_EnToCn_E_n { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_opq> WxDic_SearchKey_EnToCn_E_opq { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_rs> WxDic_SearchKey_EnToCn_E_rs { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_tuvw> WxDic_SearchKey_EnToCn_E_tuvw { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_E_xyz> WxDic_SearchKey_EnToCn_E_xyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_a> WxDic_SearchKey_EnToCn_F_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_bcde> WxDic_SearchKey_EnToCn_F_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_fghi> WxDic_SearchKey_EnToCn_F_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_jkl> WxDic_SearchKey_EnToCn_F_jkl { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_mno> WxDic_SearchKey_EnToCn_F_mno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_pqr> WxDic_SearchKey_EnToCn_F_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_F_stuvwxyz> WxDic_SearchKey_EnToCn_F_stuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_a> WxDic_SearchKey_EnToCn_G_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_bcde> WxDic_SearchKey_EnToCn_G_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_fghi> WxDic_SearchKey_EnToCn_G_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_jkl> WxDic_SearchKey_EnToCn_G_jkl { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_mno> WxDic_SearchKey_EnToCn_G_mno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_pqr> WxDic_SearchKey_EnToCn_G_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_G_stuvwxyz> WxDic_SearchKey_EnToCn_G_stuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_H_a> WxDic_SearchKey_EnToCn_H_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_H_bcde> WxDic_SearchKey_EnToCn_H_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_H_fghi> WxDic_SearchKey_EnToCn_H_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_H_jklmno> WxDic_SearchKey_EnToCn_H_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_H_pqrstuvwxyz> WxDic_SearchKey_EnToCn_H_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_I_abcd> WxDic_SearchKey_EnToCn_I_abcd { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_I_efghijklm> WxDic_SearchKey_EnToCn_I_efghijklm { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_I_n> WxDic_SearchKey_EnToCn_I_n { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_I_opqrstuvwxyz> WxDic_SearchKey_EnToCn_I_opqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_J> WxDic_SearchKey_EnToCn_J { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_K> WxDic_SearchKey_EnToCn_K { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_L_a> WxDic_SearchKey_EnToCn_L_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_L_bcde> WxDic_SearchKey_EnToCn_L_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_L_fghi> WxDic_SearchKey_EnToCn_L_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_L_jklmno> WxDic_SearchKey_EnToCn_L_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_L_pqrstuvwxyz> WxDic_SearchKey_EnToCn_L_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_M_a> WxDic_SearchKey_EnToCn_M_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_M_bcde> WxDic_SearchKey_EnToCn_M_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_M_fghi> WxDic_SearchKey_EnToCn_M_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_M_jklmno> WxDic_SearchKey_EnToCn_M_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_M_pqrstuvwxyz> WxDic_SearchKey_EnToCn_M_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_N_a> WxDic_SearchKey_EnToCn_N_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_N_bcde> WxDic_SearchKey_EnToCn_N_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_N_fghi> WxDic_SearchKey_EnToCn_N_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_N_jklmno> WxDic_SearchKey_EnToCn_N_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_N_pqrstuvwxyz> WxDic_SearchKey_EnToCn_N_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_ab> WxDic_SearchKey_EnToCn_O_ab { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_cdef> WxDic_SearchKey_EnToCn_O_cdef { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_ghijklmn> WxDic_SearchKey_EnToCn_O_ghijklmn { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_op> WxDic_SearchKey_EnToCn_O_op { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_qr> WxDic_SearchKey_EnToCn_O_qr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_stu> WxDic_SearchKey_EnToCn_O_stu { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_O_vwxyz> WxDic_SearchKey_EnToCn_O_vwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_a> WxDic_SearchKey_EnToCn_P_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_bcde> WxDic_SearchKey_EnToCn_P_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_fgh> WxDic_SearchKey_EnToCn_P_fgh { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_i> WxDic_SearchKey_EnToCn_P_i { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_jkl> WxDic_SearchKey_EnToCn_P_jkl { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_mno> WxDic_SearchKey_EnToCn_P_mno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_pqr> WxDic_SearchKey_EnToCn_P_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_P_stuvwxyz> WxDic_SearchKey_EnToCn_P_stuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_Q> WxDic_SearchKey_EnToCn_Q { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_R_a> WxDic_SearchKey_EnToCn_R_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_R_bcde> WxDic_SearchKey_EnToCn_R_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_R_fghi> WxDic_SearchKey_EnToCn_R_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_R_jklmno> WxDic_SearchKey_EnToCn_R_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_R_pqrstuvwxyz> WxDic_SearchKey_EnToCn_R_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_a> WxDic_SearchKey_EnToCn_S_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_bc> WxDic_SearchKey_EnToCn_S_bc { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_de> WxDic_SearchKey_EnToCn_S_de { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_fgh> WxDic_SearchKey_EnToCn_S_fgh { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_i> WxDic_SearchKey_EnToCn_S_i { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_jk> WxDic_SearchKey_EnToCn_S_jk { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_l> WxDic_SearchKey_EnToCn_S_l { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_mn> WxDic_SearchKey_EnToCn_S_mn { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_o> WxDic_SearchKey_EnToCn_S_o { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_p> WxDic_SearchKey_EnToCn_S_p { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_qst> WxDic_SearchKey_EnToCn_S_qst { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_u> WxDic_SearchKey_EnToCn_S_u { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_S_vwxyz> WxDic_SearchKey_EnToCn_S_vwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_a> WxDic_SearchKey_EnToCn_T_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_bcde> WxDic_SearchKey_EnToCn_T_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_fgh> WxDic_SearchKey_EnToCn_T_fgh { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_i> WxDic_SearchKey_EnToCn_T_i { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_o> WxDic_SearchKey_EnToCn_T_o { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_pqr> WxDic_SearchKey_EnToCn_T_pqr { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_stu> WxDic_SearchKey_EnToCn_T_stu { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_vwxyz> WxDic_SearchKey_EnToCn_T_vwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_U_abcdefghijklmn> WxDic_SearchKey_EnToCn_U_abcdefghijklmn { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_U_opqrstuvwxyz> WxDic_SearchKey_EnToCn_U_opqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_V_a> WxDic_SearchKey_EnToCn_V_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_V_bcde> WxDic_SearchKey_EnToCn_V_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_V_fghi> WxDic_SearchKey_EnToCn_V_fghi { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_V_jklmnopqrstuvwxyz> WxDic_SearchKey_EnToCn_V_jklmnopqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_W_a> WxDic_SearchKey_EnToCn_W_a { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_W_bcde> WxDic_SearchKey_EnToCn_W_bcde { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_W_fgh> WxDic_SearchKey_EnToCn_W_fgh { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_W_i> WxDic_SearchKey_EnToCn_W_i { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_W_jklmno> WxDic_SearchKey_EnToCn_W_jklmno { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_W_pqrstuvwxyz> WxDic_SearchKey_EnToCn_W_pqrstuvwxyz { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_X> WxDic_SearchKey_EnToCn_X { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_Y> WxDic_SearchKey_EnToCn_Y { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_Z> WxDic_SearchKey_EnToCn_Z { get; set; }
        public DbSet<WxDic_EnToCn_C_stuvwxyz> WxDic_EnToCn_C_stuvwxyz { get; set; }
        public DbSet<WxDic_EnToCn_T_jklmn> WxDic_EnToCn_T_jklmn { get; set; }
        public DbSet<WxDic_SearchKey_EnToCn_T_jklmn> WxDic_SearchKey_EnToCn_T_jklmn { get; set; }
        public DbSet<WxDic_CnToEn_a> WxDic_CnToEn_a { get; set; }
        public DbSet<WxDic_CnToEn_b> WxDic_CnToEn_b { get; set; }
        public DbSet<WxDic_CnToEn_c> WxDic_CnToEn_c { get; set; }
        public DbSet<WxDic_CnToEn_d> WxDic_CnToEn_d { get; set; }
        public DbSet<WxDic_CnToEn_e> WxDic_CnToEn_e { get; set; }
        public DbSet<WxDic_CnToEn_f> WxDic_CnToEn_f { get; set; }
        public DbSet<WxDic_CnToEn_g> WxDic_CnToEn_g { get; set; }
        public DbSet<WxDic_CnToEn_h> WxDic_CnToEn_h { get; set; }
        public DbSet<WxDic_CnToEn_i> WxDic_CnToEn_i { get; set; }
        public DbSet<WxDic_CnToEn_j> WxDic_CnToEn_j { get; set; }
        public DbSet<WxDic_CnToEn_k> WxDic_CnToEn_k { get; set; }
        public DbSet<WxDic_CnToEn_l> WxDic_CnToEn_l { get; set; }
        public DbSet<WxDic_CnToEn_m> WxDic_CnToEn_m { get; set; }
        public DbSet<WxDic_CnToEn_n> WxDic_CnToEn_n { get; set; }
        public DbSet<WxDic_CnToEn_o> WxDic_CnToEn_o { get; set; }
        public DbSet<WxDic_CnToEn_p> WxDic_CnToEn_p { get; set; }
        public DbSet<WxDic_CnToEn_q> WxDic_CnToEn_q { get; set; }
        public DbSet<WxDic_CnToEn_r> WxDic_CnToEn_r { get; set; }
        public DbSet<WxDic_CnToEn_s> WxDic_CnToEn_s { get; set; }
        public DbSet<WxDic_CnToEn_t> WxDic_CnToEn_t { get; set; }
        public DbSet<WxDic_CnToEn_w> WxDic_CnToEn_w { get; set; }
        public DbSet<WxDic_CnToEn_x> WxDic_CnToEn_x { get; set; }
        public DbSet<WxDic_CnToEn_y> WxDic_CnToEn_y { get; set; }
        public DbSet<WxDic_CnToEn_z> WxDic_CnToEn_z { get; set; }
    }
}