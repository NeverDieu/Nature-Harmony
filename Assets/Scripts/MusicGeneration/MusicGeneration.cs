using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGeneration : MonoBehaviour
{

    // Variable pour mettre directement dans l'inspecteur le nom de l'event avec les mélodies
    private FMOD.Studio.EventInstance gp_fmod;
    public FMODUnity.EventReference gp_fmodEvent;
    private FMOD.Studio.EventInstance gd_fmod;
    public FMODUnity.EventReference gd_fmodEvent;
    private FMOD.Studio.EventInstance gs_fmod;
    public FMODUnity.EventReference gs_fmodEvent;
    private FMOD.Studio.EventInstance gm_fmod;
    public FMODUnity.EventReference gm_fmodEvent;

    private FMOD.Studio.EventInstance pp_fmod;
    public FMODUnity.EventReference pp_fmodEvent;
    private FMOD.Studio.EventInstance pd_fmod;
    public FMODUnity.EventReference pd_fmodEvent;
    private FMOD.Studio.EventInstance ps_fmod;
    public FMODUnity.EventReference ps_fmodEvent;
    private FMOD.Studio.EventInstance pm_fmod;
    public FMODUnity.EventReference pm_fmodEvent;

    private FMOD.Studio.EventInstance bp_fmod;
    public FMODUnity.EventReference bp_fmodEvent;
    private FMOD.Studio.EventInstance bd_fmod;
    public FMODUnity.EventReference bd_fmodEvent;
    private FMOD.Studio.EventInstance bs_fmod;
    public FMODUnity.EventReference bs_fmodEvent;
    private FMOD.Studio.EventInstance bm_fmod;
    public FMODUnity.EventReference bm_fmodEvent;

    private FMOD.Studio.EventInstance fp_fmod;
    public FMODUnity.EventReference fp_fmodEvent;
    private FMOD.Studio.EventInstance fd_fmod;
    public FMODUnity.EventReference fd_fmodEvent;
    private FMOD.Studio.EventInstance fs_fmod;
    public FMODUnity.EventReference fs_fmodEvent;
    private FMOD.Studio.EventInstance fm_fmod;
    public FMODUnity.EventReference fm_fmodEvent;

    private FMOD.Studio.EventInstance vp_fmod;
    public FMODUnity.EventReference vp_fmodEvent;
    private FMOD.Studio.EventInstance vd_fmod;
    public FMODUnity.EventReference vd_fmodEvent;
    private FMOD.Studio.EventInstance vs_fmod;
    public FMODUnity.EventReference vs_fmodEvent;
    private FMOD.Studio.EventInstance vm_fmod;
    public FMODUnity.EventReference vm_fmodEvent;

    //Variable qui modifie l'intensité mélodique
    [SerializeField]
    [Range(0f, 12f)]
    private int gp_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int gd_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int gs_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int gm_melody;

    [SerializeField]
    [Range(0f, 12f)]
    private int pp_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int pd_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int ps_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int pm_melody;

    [SerializeField]
    [Range(0f, 12f)]
    private int bp_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int bd_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int bs_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int bm_melody;

    [SerializeField]
    [Range(0f, 12f)]
    private int fp_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int fd_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int fs_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int fm_melody;

    [SerializeField]
    [Range(0f, 12f)]
    private int vp_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int vd_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int vs_melody;
    [SerializeField]
    [Range(0f, 12f)]
    private int vm_melody;

    // Variable pour mettre directement dans l'inspecteur le nom de l'event avec les accords
    private FMOD.Studio.EventInstance gp_ch_fmod;
    public FMODUnity.EventReference gp_ch_fmodEvent;

    //Variable qui modifie le nombre d'accords et le nombre de notes par accord
    [SerializeField]
    [Range(0f, 8f)]
    private int gp_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int gp_chord8;

    private FMOD.Studio.EventInstance gd_ch_fmod;
    public FMODUnity.EventReference gd_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int gd_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int gd_chord8;

    private FMOD.Studio.EventInstance gs_ch_fmod;
    public FMODUnity.EventReference gs_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int gs_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int gs_chord8;

    private FMOD.Studio.EventInstance gm_ch_fmod;
    public FMODUnity.EventReference gm_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int gm_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int gm_chord8;

    // Variable pour mettre directement dans l'inspecteur le nom de l'event avec les accords
    private FMOD.Studio.EventInstance pp_ch_fmod;
    public FMODUnity.EventReference pp_ch_fmodEvent;

    //Variable qui modifie le nombre d'accords et le nombre de notes par accord
    [SerializeField]
    [Range(0f, 8f)]
    private int pp_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int pp_chord8;

    private FMOD.Studio.EventInstance pd_ch_fmod;
    public FMODUnity.EventReference pd_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int pd_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int pd_chord8;

    private FMOD.Studio.EventInstance ps_ch_fmod;
    public FMODUnity.EventReference ps_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int ps_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int ps_chord8;

    private FMOD.Studio.EventInstance pm_ch_fmod;
    public FMODUnity.EventReference pm_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int pm_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int pm_chord8;

    // Variable pour mettre directement dans l'inspecteur le nom de l'event avec les accords
    private FMOD.Studio.EventInstance bp_ch_fmod;
    public FMODUnity.EventReference bp_ch_fmodEvent;

    //Variable qui modifie le nombre d'accords et le nombre de notes par accord
    [SerializeField]
    [Range(0f, 8f)]
    private int bp_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int bp_chord8;

    private FMOD.Studio.EventInstance bd_ch_fmod;
    public FMODUnity.EventReference bd_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int bd_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int bd_chord8;

    private FMOD.Studio.EventInstance bs_ch_fmod;
    public FMODUnity.EventReference bs_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int bs_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int bs_chord8;

    private FMOD.Studio.EventInstance bm_ch_fmod;
    public FMODUnity.EventReference bm_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int bm_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int bm_chord8;

    // Variable pour mettre directement dans l'inspecteur le nom de l'event avec les accords
    private FMOD.Studio.EventInstance fp_ch_fmod;
    public FMODUnity.EventReference fp_ch_fmodEvent;

    //Variable qui modifie le nombre d'accords et le nombre de notes par accord
    [SerializeField]
    [Range(0f, 8f)]
    private int fp_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int fp_chord8;

    private FMOD.Studio.EventInstance fd_ch_fmod;
    public FMODUnity.EventReference fd_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int fd_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int fd_chord8;

    private FMOD.Studio.EventInstance fs_ch_fmod;
    public FMODUnity.EventReference fs_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int fs_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int fs_chord8;

    private FMOD.Studio.EventInstance fm_ch_fmod;
    public FMODUnity.EventReference fm_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int fm_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int fm_chord8;

    // Variable pour mettre directement dans l'inspecteur le nom de l'event avec les accords
    private FMOD.Studio.EventInstance vp_ch_fmod;
    public FMODUnity.EventReference vp_ch_fmodEvent;

    //Variable qui modifie le nombre d'accords et le nombre de notes par accord
    [SerializeField]
    [Range(0f, 8f)]
    private int vp_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int vp_chord8;

    private FMOD.Studio.EventInstance vd_ch_fmod;
    public FMODUnity.EventReference vd_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int vd_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int vd_chord8;

    private FMOD.Studio.EventInstance vs_ch_fmod;
    public FMODUnity.EventReference vs_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int vs_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int vs_chord8;

    private FMOD.Studio.EventInstance vm_ch_fmod;
    public FMODUnity.EventReference vm_ch_fmodEvent;

    [SerializeField]
    [Range(0f, 8f)]
    private int vm_chords;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord1;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord2;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord3;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord4;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord5;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord6;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord7;
    [SerializeField]
    [Range(0f, 9f)]
    private int vm_chord8;

    [SerializeField]
    private int countGP;
    [SerializeField]
    private int countGD;
    [SerializeField]
    private int countGS;
    [SerializeField]
    private int countGM;
    [SerializeField]
    private int countPP;
    [SerializeField]
    private int countPD;
    [SerializeField]
    private int countPS;
    [SerializeField]
    private int countPM;
    [SerializeField]
    private int countBP;
    [SerializeField]
    private int countBD;
    [SerializeField]
    private int countBS;
    [SerializeField]
    private int countBM;
    [SerializeField]
    private int countFP;
    [SerializeField]
    private int countFD;
    [SerializeField]
    private int countFS;
    [SerializeField]
    private int countFM;
    [SerializeField]
    private int countVP;
    [SerializeField]
    private int countVD;
    [SerializeField]
    private int countVS;
    [SerializeField]
    private int countVM;

    void Start()
    {
        gp_fmod = FMODUnity.RuntimeManager.CreateInstance(gp_fmodEvent);
        gd_fmod = FMODUnity.RuntimeManager.CreateInstance(gd_fmodEvent);
        gs_fmod = FMODUnity.RuntimeManager.CreateInstance(gs_fmodEvent);
        gm_fmod = FMODUnity.RuntimeManager.CreateInstance(gm_fmodEvent);
        pp_fmod = FMODUnity.RuntimeManager.CreateInstance(pp_fmodEvent);
        pd_fmod = FMODUnity.RuntimeManager.CreateInstance(pd_fmodEvent);
        ps_fmod = FMODUnity.RuntimeManager.CreateInstance(ps_fmodEvent);
        pm_fmod = FMODUnity.RuntimeManager.CreateInstance(pm_fmodEvent);
        bp_fmod = FMODUnity.RuntimeManager.CreateInstance(bp_fmodEvent);
        bd_fmod = FMODUnity.RuntimeManager.CreateInstance(bd_fmodEvent);
        bs_fmod = FMODUnity.RuntimeManager.CreateInstance(bs_fmodEvent);
        bm_fmod = FMODUnity.RuntimeManager.CreateInstance(bm_fmodEvent);
        fp_fmod = FMODUnity.RuntimeManager.CreateInstance(fp_fmodEvent);
        fd_fmod = FMODUnity.RuntimeManager.CreateInstance(fd_fmodEvent);
        fs_fmod = FMODUnity.RuntimeManager.CreateInstance(fs_fmodEvent);
        fm_fmod = FMODUnity.RuntimeManager.CreateInstance(fm_fmodEvent);
        vp_fmod = FMODUnity.RuntimeManager.CreateInstance(vp_fmodEvent);
        vd_fmod = FMODUnity.RuntimeManager.CreateInstance(vd_fmodEvent);
        vs_fmod = FMODUnity.RuntimeManager.CreateInstance(vs_fmodEvent);
        vm_fmod = FMODUnity.RuntimeManager.CreateInstance(vm_fmodEvent);

        gp_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(gp_ch_fmodEvent);
        gd_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(gd_ch_fmodEvent);
        gs_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(gs_ch_fmodEvent);
        gm_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(gm_ch_fmodEvent);
        pp_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(pp_ch_fmodEvent);
        pd_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(pd_ch_fmodEvent);
        ps_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(ps_ch_fmodEvent);
        pm_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(pm_ch_fmodEvent);
        bp_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(bp_ch_fmodEvent);
        bd_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(bd_ch_fmodEvent);
        bs_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(bs_ch_fmodEvent);
        bm_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(bm_ch_fmodEvent);
        fp_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(fp_ch_fmodEvent);
        fd_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(fd_ch_fmodEvent);
        fs_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(fs_ch_fmodEvent);
        fm_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(fm_ch_fmodEvent);
        vp_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(vp_ch_fmodEvent);
        vd_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(vd_ch_fmodEvent);
        vs_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(vs_ch_fmodEvent);
        vm_ch_fmod = FMODUnity.RuntimeManager.CreateInstance(vm_ch_fmodEvent);

        if (gameObject.name == "Plaine")
        {
            Debug.Log("plain music launch ");
            gp_fmod.start();
            pp_fmod.start();
            bp_fmod.start();
            fp_fmod.start();
            vp_fmod.start();

            gp_ch_fmod.start();
            pp_ch_fmod.start();
            bp_ch_fmod.start();
            fp_ch_fmod.start();
            vp_ch_fmod.start();
        }

        if (gameObject.name == "Désert")
        {
            Debug.Log("desert music launch ");
            gd_fmod.start();
            pd_fmod.start();
            bd_fmod.start();
            fd_fmod.start();
            vd_fmod.start();

            gd_ch_fmod.start();
            pd_ch_fmod.start();
            bd_ch_fmod.start();
            fd_ch_fmod.start();
            vd_ch_fmod.start();
        }

        if (gameObject.name == "Marais")
        {
            Debug.Log("swamp music launch ");
            gs_fmod.start();
            ps_fmod.start();
            bs_fmod.start();
            fs_fmod.start();
            vs_fmod.start();

            gs_ch_fmod.start();
            ps_ch_fmod.start();
            bs_ch_fmod.start();
            fs_ch_fmod.start();
            vs_ch_fmod.start();
        }

        if (gameObject.name == "Montagne")
        {
            Debug.Log("mountain music launch ");
            gm_fmod.start();
            pm_fmod.start();
            bm_fmod.start();
            fm_fmod.start();
            vm_fmod.start();

            gm_ch_fmod.start();
            pm_ch_fmod.start();
            bm_ch_fmod.start();
            fm_ch_fmod.start();
            vm_ch_fmod.start();
        }
        Debug.Log(" music launch done");
        Debug.Log(gameObject.name);

    }

    void Update()
    {

        countGP = gameObject.GetComponent<ObjectDetection>().objectNumberArbres;
        countGD = gameObject.GetComponent<ObjectDetection>().objectNumberArbres;
        countGS = gameObject.GetComponent<ObjectDetection>().objectNumberArbres;
        countGM = gameObject.GetComponent<ObjectDetection>().objectNumberArbres;

        countPP = GameObject.FindGameObjectsWithTag("Fleur").Length - 1;
        countPD = GameObject.FindGameObjectsWithTag("Fleur").Length - 1;
        countPS = GameObject.FindGameObjectsWithTag("Fleur").Length - 1;
        countPM = GameObject.FindGameObjectsWithTag("Fleur").Length - 1;

        countBP = GameObject.FindGameObjectsWithTag("Rocher").Length - 1;
        countBD = GameObject.FindGameObjectsWithTag("Rocher").Length - 1;
        countBS = GameObject.FindGameObjectsWithTag("Rocher").Length - 1;
        countBM = GameObject.FindGameObjectsWithTag("Rocher").Length - 1;

        countFP = GameObject.FindGameObjectsWithTag("Champignon").Length - 1;
        countFD = GameObject.FindGameObjectsWithTag("Champignon").Length - 1;
        countFS = GameObject.FindGameObjectsWithTag("Champignon").Length - 1;
        countFM = GameObject.FindGameObjectsWithTag("Champignon").Length - 1;

        countVP = GameObject.FindGameObjectsWithTag("Buisson").Length - 1;
        countVD = GameObject.FindGameObjectsWithTag("Buisson").Length - 1;
        countVS = GameObject.FindGameObjectsWithTag("Buisson").Length - 1;
        countVM = GameObject.FindGameObjectsWithTag("Buisson").Length - 1;

        gp_melody = countGP;
        gd_melody = countGD;
        gs_melody = countGS;
        gm_melody = countGM;

        pp_melody = countPP;
        pd_melody = countPD;
        ps_melody = countPS;
        pm_melody = countPM;

        bp_melody = countBP;
        bd_melody = countBD;
        bs_melody = countBS;
        bm_melody = countBM;

        fp_melody = countFP;
        fd_melody = countFD;
        fs_melody = countFS;
        fm_melody = countFM;

        vp_melody = countVP;
        vd_melody = countVD;
        vs_melody = countVS;
        vm_melody = countVM;


        // Mélodies de la guitare de la plaine

        gp_fmod.setParameterByName("GP_Melody", gp_melody);

        if (gp_melody == 1)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (gp_melody == 2)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (gp_melody == 3)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (gp_melody == 4)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (gp_melody == 5)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (gp_melody == 6)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (gp_melody == 7)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (gp_melody == 8)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (gp_melody == 9)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (gp_melody == 10)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (gp_melody == 11)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (gp_melody == 12)
        {
            gp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        gp_ch_fmod.setParameterByName("ChordsNumber", gp_chords);
        gp_ch_fmod.setParameterByName("Chord1", gp_chord1);
        gp_ch_fmod.setParameterByName("Chord2", gp_chord2);
        gp_ch_fmod.setParameterByName("Chord3", gp_chord3);
        gp_ch_fmod.setParameterByName("Chord4", gp_chord4);
        gp_ch_fmod.setParameterByName("Chord5", gp_chord5);
        gp_ch_fmod.setParameterByName("Chord6", gp_chord6);
        gp_ch_fmod.setParameterByName("Chord7", gp_chord7);
        gp_ch_fmod.setParameterByName("Chord8", gp_chord8);

        if (gp_chords == 1)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (gp_chords == 2)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (gp_chords == 3)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (gp_chords == 4)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (gp_chords == 5)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (gp_chords == 6)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (gp_chords == 7)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (gp_chords == 8)
        {
            gp_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (gp_chord1 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (gp_chord1 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (gp_chord1 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (gp_chord1 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (gp_chord1 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (gp_chord1 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (gp_chord1 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (gp_chord1 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (gp_chord1 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (gp_chord2 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (gp_chord2 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (gp_chord2 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (gp_chord2 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (gp_chord2 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (gp_chord2 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (gp_chord2 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (gp_chord2 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (gp_chord2 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (gp_chord3 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (gp_chord3 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (gp_chord3 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (gp_chord3 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (gp_chord3 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (gp_chord3 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (gp_chord3 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (gp_chord3 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (gp_chord3 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (gp_chord4 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (gp_chord4 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (gp_chord4 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (gp_chord4 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (gp_chord4 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (gp_chord4 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (gp_chord4 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (gp_chord4 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (gp_chord4 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (gp_chord5 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (gp_chord5 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (gp_chord5 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (gp_chord5 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (gp_chord5 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (gp_chord5 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (gp_chord5 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (gp_chord5 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (gp_chord5 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (gp_chord6 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (gp_chord6 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (gp_chord6 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (gp_chord6 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (gp_chord6 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (gp_chord6 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (gp_chord6 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (gp_chord6 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (gp_chord6 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (gp_chord7 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (gp_chord7 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (gp_chord7 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (gp_chord7 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (gp_chord7 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (gp_chord7 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (gp_chord7 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (gp_chord7 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (gp_chord7 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (gp_chord8 == 1)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (gp_chord8 == 2)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (gp_chord8 == 3)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (gp_chord8 == 4)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (gp_chord8 == 5)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (gp_chord8 == 6)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (gp_chord8 == 7)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (gp_chord8 == 8)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (gp_chord8 == 9)
        {
            gp_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }

        // Mélodies de la guitare du désert

        gd_fmod.setParameterByName("GP_Melody", gd_melody);

        if (gd_melody == 1)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (gd_melody == 2)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (gd_melody == 3)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (gd_melody == 4)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (gd_melody == 5)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (gd_melody == 6)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (gd_melody == 7)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (gd_melody == 8)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (gd_melody == 9)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (gd_melody == 10)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (gd_melody == 11)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (gd_melody == 12)
        {
            gd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        gd_ch_fmod.setParameterByName("ChordsNumber", gd_chords);
        gd_ch_fmod.setParameterByName("Chord1", gd_chord1);
        gd_ch_fmod.setParameterByName("Chord2", gd_chord2);
        gd_ch_fmod.setParameterByName("Chord3", gd_chord3);
        gd_ch_fmod.setParameterByName("Chord4", gd_chord4);
        gd_ch_fmod.setParameterByName("Chord5", gd_chord5);
        gd_ch_fmod.setParameterByName("Chord6", gd_chord6);
        gd_ch_fmod.setParameterByName("Chord7", gd_chord7);
        gd_ch_fmod.setParameterByName("Chord8", gd_chord8);

        if (gd_chords == 1)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (gd_chords == 2)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (gd_chords == 3)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (gd_chords == 4)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (gd_chords == 5)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (gd_chords == 6)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (gd_chords == 7)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (gd_chords == 8)
        {
            gd_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (gd_chord1 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (gd_chord1 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (gd_chord1 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (gd_chord1 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (gd_chord1 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (gd_chord1 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (gd_chord1 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (gd_chord1 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (gd_chord1 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (gd_chord2 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (gd_chord2 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (gd_chord2 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (gd_chord2 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (gd_chord2 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (gd_chord2 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (gd_chord2 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (gd_chord2 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (gd_chord2 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (gd_chord3 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (gd_chord3 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (gd_chord3 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (gd_chord3 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (gd_chord3 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (gd_chord3 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (gd_chord3 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (gd_chord3 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (gd_chord3 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (gd_chord4 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (gd_chord4 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (gd_chord4 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (gd_chord4 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (gd_chord4 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (gd_chord4 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (gd_chord4 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (gd_chord4 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (gd_chord4 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (gd_chord5 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (gd_chord5 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (gd_chord5 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (gd_chord5 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (gd_chord5 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (gd_chord5 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (gd_chord5 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (gd_chord5 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (gd_chord5 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (gd_chord6 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (gd_chord6 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (gd_chord6 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (gd_chord6 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (gd_chord6 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (gd_chord6 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (gd_chord6 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (gd_chord6 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (gd_chord6 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (gd_chord7 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (gd_chord7 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (gd_chord7 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (gd_chord7 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (gd_chord7 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (gd_chord7 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (gd_chord7 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (gd_chord7 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (gd_chord7 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (gd_chord8 == 1)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (gd_chord8 == 2)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (gd_chord8 == 3)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (gd_chord8 == 4)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (gd_chord8 == 5)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (gd_chord8 == 6)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (gd_chord8 == 7)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (gd_chord8 == 8)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (gd_chord8 == 9)
        {
            gd_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la guitare du marais

        gs_fmod.setParameterByName("GP_Melody", gs_melody);

        if (gs_melody == 1)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (gs_melody == 2)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (gs_melody == 3)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (gs_melody == 4)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (gs_melody == 5)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (gs_melody == 6)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (gs_melody == 7)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (gs_melody == 8)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (gs_melody == 9)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (gs_melody == 10)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (gs_melody == 11)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (gs_melody == 12)
        {
            gs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        gs_ch_fmod.setParameterByName("ChordsNumber", gs_chords);
        gs_ch_fmod.setParameterByName("Chord1", gs_chord1);
        gs_ch_fmod.setParameterByName("Chord2", gs_chord2);
        gs_ch_fmod.setParameterByName("Chord3", gs_chord3);
        gs_ch_fmod.setParameterByName("Chord4", gs_chord4);
        gs_ch_fmod.setParameterByName("Chord5", gs_chord5);
        gs_ch_fmod.setParameterByName("Chord6", gs_chord6);
        gs_ch_fmod.setParameterByName("Chord7", gs_chord7);
        gs_ch_fmod.setParameterByName("Chord8", gs_chord8);

        if (gs_chords == 1)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (gs_chords == 2)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (gs_chords == 3)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (gs_chords == 4)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (gs_chords == 5)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (gs_chords == 6)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (gs_chords == 7)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (gs_chords == 8)
        {
            gs_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (gs_chord1 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (gs_chord1 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (gs_chord1 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (gs_chord1 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (gs_chord1 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (gs_chord1 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (gs_chord1 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (gs_chord1 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (gs_chord1 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (gs_chord2 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (gs_chord2 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (gs_chord2 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (gs_chord2 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (gs_chord2 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (gs_chord2 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (gs_chord2 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (gs_chord2 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (gs_chord2 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (gs_chord3 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (gs_chord3 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (gs_chord3 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (gs_chord3 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (gs_chord3 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (gs_chord3 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (gs_chord3 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (gs_chord3 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (gs_chord3 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (gs_chord4 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (gs_chord4 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (gs_chord4 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (gs_chord4 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (gs_chord4 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (gs_chord4 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (gs_chord4 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (gs_chord4 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (gs_chord4 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (gs_chord5 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (gs_chord5 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (gs_chord5 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (gs_chord5 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (gs_chord5 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (gs_chord5 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (gs_chord5 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (gs_chord5 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (gs_chord5 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (gs_chord6 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (gs_chord6 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (gs_chord6 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (gs_chord6 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (gs_chord6 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (gs_chord6 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (gs_chord6 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (gs_chord6 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (gs_chord6 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (gs_chord7 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (gs_chord7 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (gs_chord7 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (gs_chord7 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (gs_chord7 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (gs_chord7 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (gs_chord7 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (gs_chord7 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (gs_chord7 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (gs_chord8 == 1)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (gs_chord8 == 2)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (gs_chord8 == 3)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (gs_chord8 == 4)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (gs_chord8 == 5)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (gs_chord8 == 6)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (gs_chord8 == 7)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (gs_chord8 == 8)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (gs_chord8 == 9)
        {
            gs_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la guitare de la montagne

        gm_fmod.setParameterByName("GP_Melody", gm_melody);

        if (gm_melody == 1)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (gm_melody == 2)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (gm_melody == 3)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (gm_melody == 4)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (gm_melody == 5)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (gm_melody == 6)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (gm_melody == 7)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (gm_melody == 8)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (gm_melody == 9)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (gm_melody == 10)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (gm_melody == 11)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (gm_melody == 12)
        {
            gm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        gm_ch_fmod.setParameterByName("ChordsNumber", gm_chords);
        gm_ch_fmod.setParameterByName("Chord1", gm_chord1);
        gm_ch_fmod.setParameterByName("Chord2", gm_chord2);
        gm_ch_fmod.setParameterByName("Chord3", gm_chord3);
        gm_ch_fmod.setParameterByName("Chord4", gm_chord4);
        gm_ch_fmod.setParameterByName("Chord5", gm_chord5);
        gm_ch_fmod.setParameterByName("Chord6", gm_chord6);
        gm_ch_fmod.setParameterByName("Chord7", gm_chord7);
        gm_ch_fmod.setParameterByName("Chord8", gm_chord8);

        if (gm_chords == 1)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (gm_chords == 2)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (gm_chords == 3)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (gm_chords == 4)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (gm_chords == 5)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (gm_chords == 6)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (gm_chords == 7)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (gm_chords == 8)
        {
            gm_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (gm_chord1 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (gm_chord1 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (gm_chord1 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (gm_chord1 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (gm_chord1 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (gm_chord1 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (gm_chord1 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (gm_chord1 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (gm_chord1 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (gm_chord2 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (gm_chord2 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (gm_chord2 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (gm_chord2 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (gm_chord2 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (gm_chord2 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (gm_chord2 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (gm_chord2 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (gm_chord2 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (gm_chord3 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (gm_chord3 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (gm_chord3 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (gm_chord3 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (gm_chord3 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (gm_chord3 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (gm_chord3 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (gm_chord3 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (gm_chord3 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (gm_chord4 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (gm_chord4 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (gm_chord4 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (gm_chord4 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (gm_chord4 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (gm_chord4 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (gm_chord4 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (gm_chord4 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (gm_chord4 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (gm_chord5 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (gm_chord5 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (gm_chord5 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (gm_chord5 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (gm_chord5 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (gm_chord5 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (gm_chord5 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (gm_chord5 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (gm_chord5 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (gm_chord6 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (gm_chord6 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (gm_chord6 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (gm_chord6 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (gm_chord6 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (gm_chord6 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (gm_chord6 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (gm_chord6 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (gm_chord6 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (gm_chord7 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (gm_chord7 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (gm_chord7 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (gm_chord7 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (gm_chord7 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (gm_chord7 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (gm_chord7 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (gm_chord7 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (gm_chord7 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (gm_chord8 == 1)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (gm_chord8 == 2)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (gm_chord8 == 3)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (gm_chord8 == 4)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (gm_chord8 == 5)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (gm_chord8 == 6)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (gm_chord8 == 7)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (gm_chord8 == 8)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (gm_chord8 == 9)
        {
            gm_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }




        // Mélodies du piano

        pp_fmod.setParameterByName("GP_Melody", pp_melody);

        if (pp_melody == 1)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (pp_melody == 2)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (pp_melody == 3)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (pp_melody == 4)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (pp_melody == 5)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (pp_melody == 6)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (pp_melody == 7)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (pp_melody == 8)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (pp_melody == 9)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (pp_melody == 10)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (pp_melody == 11)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (pp_melody == 12)
        {
            pp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        pp_ch_fmod.setParameterByName("ChordsNumber", pp_chords);
        pp_ch_fmod.setParameterByName("Chord1", pp_chord1);
        pp_ch_fmod.setParameterByName("Chord2", pp_chord2);
        pp_ch_fmod.setParameterByName("Chord3", pp_chord3);
        pp_ch_fmod.setParameterByName("Chord4", pp_chord4);
        pp_ch_fmod.setParameterByName("Chord5", pp_chord5);
        pp_ch_fmod.setParameterByName("Chord6", pp_chord6);
        pp_ch_fmod.setParameterByName("Chord7", pp_chord7);
        pp_ch_fmod.setParameterByName("Chord8", pp_chord8);

        if (pp_chords == 1)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (pp_chords == 2)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (pp_chords == 3)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (pp_chords == 4)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (pp_chords == 5)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (pp_chords == 6)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (pp_chords == 7)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (pp_chords == 8)
        {
            pp_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (pp_chord1 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (pp_chord1 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (pp_chord1 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (pp_chord1 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (pp_chord1 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (pp_chord1 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (pp_chord1 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (pp_chord1 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (pp_chord1 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (pp_chord2 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (pp_chord2 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (pp_chord2 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (pp_chord2 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (pp_chord2 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (pp_chord2 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (pp_chord2 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (pp_chord2 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (pp_chord2 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (pp_chord3 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (pp_chord3 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (pp_chord3 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (pp_chord3 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (pp_chord3 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (pp_chord3 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (pp_chord3 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (pp_chord3 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (pp_chord3 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (pp_chord4 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (pp_chord4 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (pp_chord4 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (pp_chord4 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (pp_chord4 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (pp_chord4 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (pp_chord4 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (pp_chord4 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (pp_chord4 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (pp_chord5 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (pp_chord5 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (pp_chord5 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (pp_chord5 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (pp_chord5 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (pp_chord5 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (pp_chord5 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (pp_chord5 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (pp_chord5 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (pp_chord6 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (pp_chord6 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (pp_chord6 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (pp_chord6 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (pp_chord6 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (pp_chord6 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (pp_chord6 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (pp_chord6 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (pp_chord6 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (pp_chord7 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (pp_chord7 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (pp_chord7 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (pp_chord7 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (pp_chord7 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (pp_chord7 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (pp_chord7 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (pp_chord7 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (pp_chord7 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (pp_chord8 == 1)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (pp_chord8 == 2)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (pp_chord8 == 3)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (pp_chord8 == 4)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (pp_chord8 == 5)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (pp_chord8 == 6)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (pp_chord8 == 7)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (pp_chord8 == 8)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (pp_chord8 == 9)
        {
            pp_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }

        // Mélodies de la guitare du désert

        pd_fmod.setParameterByName("GP_Melody", pd_melody);

        if (pd_melody == 1)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (pd_melody == 2)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (pd_melody == 3)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (pd_melody == 4)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (pd_melody == 5)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (pd_melody == 6)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (pd_melody == 7)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (pd_melody == 8)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (pd_melody == 9)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (pd_melody == 10)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (pd_melody == 11)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (pd_melody == 12)
        {
            pd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        pd_ch_fmod.setParameterByName("ChordsNumber", pd_chords);
        pd_ch_fmod.setParameterByName("Chord1", pd_chord1);
        pd_ch_fmod.setParameterByName("Chord2", pd_chord2);
        pd_ch_fmod.setParameterByName("Chord3", pd_chord3);
        pd_ch_fmod.setParameterByName("Chord4", pd_chord4);
        pd_ch_fmod.setParameterByName("Chord5", pd_chord5);
        pd_ch_fmod.setParameterByName("Chord6", pd_chord6);
        pd_ch_fmod.setParameterByName("Chord7", pd_chord7);
        pd_ch_fmod.setParameterByName("Chord8", pd_chord8);

        if (pd_chords == 1)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (pd_chords == 2)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (pd_chords == 3)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (pd_chords == 4)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (pd_chords == 5)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (pd_chords == 6)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (pd_chords == 7)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (pd_chords == 8)
        {
            pd_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (pd_chord1 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (pd_chord1 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (pd_chord1 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (pd_chord1 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (pd_chord1 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (pd_chord1 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (pd_chord1 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (pd_chord1 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (pd_chord1 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (pd_chord2 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (pd_chord2 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (pd_chord2 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (pd_chord2 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (pd_chord2 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (pd_chord2 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (pd_chord2 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (pd_chord2 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (pd_chord2 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (pd_chord3 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (pd_chord3 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (pd_chord3 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (pd_chord3 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (pd_chord3 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (pd_chord3 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (pd_chord3 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (pd_chord3 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (pd_chord3 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (pd_chord4 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (pd_chord4 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (pd_chord4 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (pd_chord4 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (pd_chord4 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (pd_chord4 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (pd_chord4 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (pd_chord4 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (pd_chord4 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (pd_chord5 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (pd_chord5 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (pd_chord5 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (pd_chord5 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (pd_chord5 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (pd_chord5 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (pd_chord5 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (pd_chord5 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (pd_chord5 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (pd_chord6 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (pd_chord6 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (pd_chord6 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (pd_chord6 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (pd_chord6 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (pd_chord6 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (pd_chord6 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (pd_chord6 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (pd_chord6 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (pd_chord7 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (pd_chord7 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (pd_chord7 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (pd_chord7 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (pd_chord7 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (pd_chord7 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (pd_chord7 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (pd_chord7 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (pd_chord7 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (pd_chord8 == 1)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (pd_chord8 == 2)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (pd_chord8 == 3)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (pd_chord8 == 4)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (pd_chord8 == 5)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (pd_chord8 == 6)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (pd_chord8 == 7)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (pd_chord8 == 8)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (pd_chord8 == 9)
        {
            pd_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la guitare du marais

        ps_fmod.setParameterByName("GP_Melody", ps_melody);

        if (ps_melody == 1)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (ps_melody == 2)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (ps_melody == 3)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (ps_melody == 4)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (ps_melody == 5)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (ps_melody == 6)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (ps_melody == 7)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (ps_melody == 8)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (ps_melody == 9)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (ps_melody == 10)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (ps_melody == 11)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (ps_melody == 12)
        {
            ps_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        ps_ch_fmod.setParameterByName("ChordsNumber", ps_chords);
        ps_ch_fmod.setParameterByName("Chord1", ps_chord1);
        ps_ch_fmod.setParameterByName("Chord2", ps_chord2);
        ps_ch_fmod.setParameterByName("Chord3", ps_chord3);
        ps_ch_fmod.setParameterByName("Chord4", ps_chord4);
        ps_ch_fmod.setParameterByName("Chord5", ps_chord5);
        ps_ch_fmod.setParameterByName("Chord6", ps_chord6);
        ps_ch_fmod.setParameterByName("Chord7", ps_chord7);
        ps_ch_fmod.setParameterByName("Chord8", ps_chord8);

        if (ps_chords == 1)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (ps_chords == 2)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (ps_chords == 3)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (ps_chords == 4)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (ps_chords == 5)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (ps_chords == 6)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (ps_chords == 7)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (ps_chords == 8)
        {
            ps_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (ps_chord1 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (ps_chord1 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (ps_chord1 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (ps_chord1 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (ps_chord1 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (ps_chord1 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (ps_chord1 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (ps_chord1 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (ps_chord1 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (ps_chord2 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (ps_chord2 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (ps_chord2 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (ps_chord2 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (ps_chord2 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (ps_chord2 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (ps_chord2 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (ps_chord2 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (ps_chord2 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (ps_chord3 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (ps_chord3 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (ps_chord3 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (ps_chord3 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (ps_chord3 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (ps_chord3 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (ps_chord3 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (ps_chord3 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (ps_chord3 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (ps_chord4 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (ps_chord4 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (ps_chord4 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (ps_chord4 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (ps_chord4 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (ps_chord4 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (ps_chord4 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (ps_chord4 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (ps_chord4 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (ps_chord5 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (ps_chord5 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (ps_chord5 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (ps_chord5 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (ps_chord5 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (ps_chord5 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (ps_chord5 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (ps_chord5 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (ps_chord5 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (ps_chord6 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (ps_chord6 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (ps_chord6 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (ps_chord6 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (ps_chord6 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (ps_chord6 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (ps_chord6 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (ps_chord6 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (ps_chord6 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (ps_chord7 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (ps_chord7 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (ps_chord7 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (ps_chord7 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (ps_chord7 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (ps_chord7 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (ps_chord7 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (ps_chord7 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (ps_chord7 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (ps_chord8 == 1)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (ps_chord8 == 2)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (ps_chord8 == 3)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (ps_chord8 == 4)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (ps_chord8 == 5)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (ps_chord8 == 6)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (ps_chord8 == 7)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (ps_chord8 == 8)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (ps_chord8 == 9)
        {
            ps_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la guitare de la montagne

        pm_fmod.setParameterByName("GP_Melody", pm_melody);

        if (pm_melody == 1)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (pm_melody == 2)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (pm_melody == 3)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (pm_melody == 4)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (pm_melody == 5)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (pm_melody == 6)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (pm_melody == 7)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (pm_melody == 8)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (pm_melody == 9)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (pm_melody == 10)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (pm_melody == 11)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (pm_melody == 12)
        {
            pm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        pm_ch_fmod.setParameterByName("ChordsNumber", pm_chords);
        pm_ch_fmod.setParameterByName("Chord1", pm_chord1);
        pm_ch_fmod.setParameterByName("Chord2", pm_chord2);
        pm_ch_fmod.setParameterByName("Chord3", pm_chord3);
        pm_ch_fmod.setParameterByName("Chord4", pm_chord4);
        pm_ch_fmod.setParameterByName("Chord5", pm_chord5);
        pm_ch_fmod.setParameterByName("Chord6", pm_chord6);
        pm_ch_fmod.setParameterByName("Chord7", pm_chord7);
        pm_ch_fmod.setParameterByName("Chord8", pm_chord8);

        if (pm_chords == 1)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (pm_chords == 2)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (pm_chords == 3)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (pm_chords == 4)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (pm_chords == 5)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (pm_chords == 6)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (pm_chords == 7)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (pm_chords == 8)
        {
            pm_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (pm_chord1 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (pm_chord1 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (pm_chord1 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (pm_chord1 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (pm_chord1 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (pm_chord1 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (pm_chord1 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (pm_chord1 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (pm_chord1 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (pm_chord2 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (pm_chord2 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (pm_chord2 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (pm_chord2 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (pm_chord2 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (pm_chord2 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (pm_chord2 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (pm_chord2 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (pm_chord2 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (pm_chord3 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (pm_chord3 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (pm_chord3 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (pm_chord3 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (pm_chord3 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (pm_chord3 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (pm_chord3 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (pm_chord3 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (pm_chord3 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (pm_chord4 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (pm_chord4 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (pm_chord4 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (pm_chord4 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (pm_chord4 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (pm_chord4 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (pm_chord4 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (pm_chord4 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (pm_chord4 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (pm_chord5 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (pm_chord5 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (pm_chord5 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (pm_chord5 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (pm_chord5 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (pm_chord5 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (pm_chord5 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (pm_chord5 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (pm_chord5 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (pm_chord6 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (pm_chord6 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (pm_chord6 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (pm_chord6 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (pm_chord6 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (pm_chord6 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (pm_chord6 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (pm_chord6 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (pm_chord6 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (pm_chord7 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (pm_chord7 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (pm_chord7 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (pm_chord7 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (pm_chord7 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (pm_chord7 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (pm_chord7 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (pm_chord7 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (pm_chord7 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (pm_chord8 == 1)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (pm_chord8 == 2)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (pm_chord8 == 3)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (pm_chord8 == 4)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (pm_chord8 == 5)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (pm_chord8 == 6)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (pm_chord8 == 7)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (pm_chord8 == 8)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (pm_chord8 == 9)
        {
            pm_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la basse de la plaine

        bp_fmod.setParameterByName("GP_Melody", bp_melody);

        if (bp_melody == 1)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (bp_melody == 2)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (bp_melody == 3)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (bp_melody == 4)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (bp_melody == 5)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (bp_melody == 6)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (bp_melody == 7)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (bp_melody == 8)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (bp_melody == 9)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (bp_melody == 10)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (bp_melody == 11)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (bp_melody == 12)
        {
            bp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        bp_ch_fmod.setParameterByName("ChordsNumber", bp_chords);
        bp_ch_fmod.setParameterByName("Chord1", bp_chord1);
        bp_ch_fmod.setParameterByName("Chord2", bp_chord2);
        bp_ch_fmod.setParameterByName("Chord3", bp_chord3);
        bp_ch_fmod.setParameterByName("Chord4", bp_chord4);
        bp_ch_fmod.setParameterByName("Chord5", bp_chord5);
        bp_ch_fmod.setParameterByName("Chord6", bp_chord6);
        bp_ch_fmod.setParameterByName("Chord7", bp_chord7);
        bp_ch_fmod.setParameterByName("Chord8", bp_chord8);

        if (bp_chords == 1)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (bp_chords == 2)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (bp_chords == 3)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (bp_chords == 4)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (bp_chords == 5)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (bp_chords == 6)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (bp_chords == 7)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (bp_chords == 8)
        {
            bp_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (bp_chord1 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (bp_chord1 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (bp_chord1 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (bp_chord1 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (bp_chord1 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (bp_chord1 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (bp_chord1 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (bp_chord1 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (bp_chord1 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (bp_chord2 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (bp_chord2 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (bp_chord2 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (bp_chord2 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (bp_chord2 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (bp_chord2 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (bp_chord2 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (bp_chord2 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (bp_chord2 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (bp_chord3 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (bp_chord3 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (bp_chord3 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (bp_chord3 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (bp_chord3 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (bp_chord3 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (bp_chord3 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (bp_chord3 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (bp_chord3 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (bp_chord4 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (bp_chord4 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (bp_chord4 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (bp_chord4 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (bp_chord4 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (bp_chord4 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (bp_chord4 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (bp_chord4 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (bp_chord4 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (bp_chord5 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (bp_chord5 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (bp_chord5 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (bp_chord5 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (bp_chord5 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (bp_chord5 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (bp_chord5 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (bp_chord5 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (bp_chord5 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (bp_chord6 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (bp_chord6 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (bp_chord6 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (bp_chord6 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (bp_chord6 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (bp_chord6 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (bp_chord6 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (bp_chord6 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (bp_chord6 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (bp_chord7 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (bp_chord7 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (bp_chord7 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (bp_chord7 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (bp_chord7 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (bp_chord7 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (bp_chord7 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (bp_chord7 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (bp_chord7 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (bp_chord8 == 1)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (bp_chord8 == 2)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (bp_chord8 == 3)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (bp_chord8 == 4)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (bp_chord8 == 5)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (bp_chord8 == 6)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (bp_chord8 == 7)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (bp_chord8 == 8)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (bp_chord8 == 9)
        {
            bp_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }

        // Mélodies de la basse du désert

        bd_fmod.setParameterByName("GP_Melody", bd_melody);

        if (bd_melody == 1)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (bd_melody == 2)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (bd_melody == 3)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (bd_melody == 4)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (bd_melody == 5)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (bd_melody == 6)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (bd_melody == 7)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (bd_melody == 8)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (bd_melody == 9)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (bd_melody == 10)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (bd_melody == 11)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (bd_melody == 12)
        {
            bd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        bd_ch_fmod.setParameterByName("ChordsNumber", bd_chords);
        bd_ch_fmod.setParameterByName("Chord1", bd_chord1);
        bd_ch_fmod.setParameterByName("Chord2", bd_chord2);
        bd_ch_fmod.setParameterByName("Chord3", bd_chord3);
        bd_ch_fmod.setParameterByName("Chord4", bd_chord4);
        bd_ch_fmod.setParameterByName("Chord5", bd_chord5);
        bd_ch_fmod.setParameterByName("Chord6", bd_chord6);
        bd_ch_fmod.setParameterByName("Chord7", bd_chord7);
        bd_ch_fmod.setParameterByName("Chord8", bd_chord8);

        if (bd_chords == 1)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (bd_chords == 2)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (bd_chords == 3)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (bd_chords == 4)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (bd_chords == 5)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (bd_chords == 6)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (bd_chords == 7)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (bd_chords == 8)
        {
            bd_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (bd_chord1 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (bd_chord1 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (bd_chord1 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (bd_chord1 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (bd_chord1 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (bd_chord1 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (bd_chord1 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (bd_chord1 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (bd_chord1 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (bd_chord2 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (bd_chord2 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (bd_chord2 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (bd_chord2 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (bd_chord2 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (bd_chord2 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (bd_chord2 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (bd_chord2 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (bd_chord2 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (bd_chord3 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (bd_chord3 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (bd_chord3 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (bd_chord3 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (bd_chord3 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (bd_chord3 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (bd_chord3 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (bd_chord3 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (bd_chord3 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (bd_chord4 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (bd_chord4 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (bd_chord4 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (bd_chord4 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (bd_chord4 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (bd_chord4 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (bd_chord4 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (bd_chord4 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (bd_chord4 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (bd_chord5 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (bd_chord5 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (bd_chord5 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (bd_chord5 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (bd_chord5 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (bd_chord5 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (bd_chord5 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (bd_chord5 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (bd_chord5 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (bd_chord6 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (bd_chord6 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (bd_chord6 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (bd_chord6 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (bd_chord6 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (bd_chord6 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (bd_chord6 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (bd_chord6 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (bd_chord6 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (bd_chord7 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (bd_chord7 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (bd_chord7 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (bd_chord7 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (bd_chord7 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (bd_chord7 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (bd_chord7 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (bd_chord7 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (bd_chord7 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (bd_chord8 == 1)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (bd_chord8 == 2)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (bd_chord8 == 3)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (bd_chord8 == 4)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (bd_chord8 == 5)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (bd_chord8 == 6)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (bd_chord8 == 7)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (bd_chord8 == 8)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (bd_chord8 == 9)
        {
            bd_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la basse du marais

        bs_fmod.setParameterByName("GP_Melody", bs_melody);

        if (bs_melody == 1)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (bs_melody == 2)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (bs_melody == 3)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (bs_melody == 4)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (bs_melody == 5)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (bs_melody == 6)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (bs_melody == 7)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (bs_melody == 8)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (bs_melody == 9)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (bs_melody == 10)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (bs_melody == 11)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (bs_melody == 12)
        {
            bs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        bs_ch_fmod.setParameterByName("ChordsNumber", bs_chords);
        bs_ch_fmod.setParameterByName("Chord1", bs_chord1);
        bs_ch_fmod.setParameterByName("Chord2", bs_chord2);
        bs_ch_fmod.setParameterByName("Chord3", bs_chord3);
        bs_ch_fmod.setParameterByName("Chord4", bs_chord4);
        bs_ch_fmod.setParameterByName("Chord5", bs_chord5);
        bs_ch_fmod.setParameterByName("Chord6", bs_chord6);
        bs_ch_fmod.setParameterByName("Chord7", bs_chord7);
        bs_ch_fmod.setParameterByName("Chord8", bs_chord8);

        if (bs_chords == 1)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (bs_chords == 2)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (bs_chords == 3)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (bs_chords == 4)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (bs_chords == 5)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (bs_chords == 6)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (bs_chords == 7)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (bs_chords == 8)
        {
            bs_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (bs_chord1 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (bs_chord1 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (bs_chord1 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (bs_chord1 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (bs_chord1 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (bs_chord1 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (bs_chord1 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (bs_chord1 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (bs_chord1 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (bs_chord2 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (bs_chord2 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (bs_chord2 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (bs_chord2 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (bs_chord2 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (bs_chord2 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (bs_chord2 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (bs_chord2 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (bs_chord2 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (bs_chord3 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (bs_chord3 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (bs_chord3 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (bs_chord3 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (bs_chord3 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (bs_chord3 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (bs_chord3 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (bs_chord3 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (bs_chord3 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (bs_chord4 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (bs_chord4 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (bs_chord4 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (bs_chord4 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (bs_chord4 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (bs_chord4 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (bs_chord4 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (bs_chord4 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (bs_chord4 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (bs_chord5 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (bs_chord5 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (bs_chord5 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (bs_chord5 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (bs_chord5 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (bs_chord5 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (bs_chord5 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (bs_chord5 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (bs_chord5 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (bs_chord6 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (bs_chord6 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (bs_chord6 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (bs_chord6 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (bs_chord6 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (bs_chord6 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (bs_chord6 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (bs_chord6 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (bs_chord6 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (bs_chord7 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (bs_chord7 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (bs_chord7 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (bs_chord7 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (bs_chord7 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (bs_chord7 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (bs_chord7 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (bs_chord7 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (bs_chord7 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (bs_chord8 == 1)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (bs_chord8 == 2)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (bs_chord8 == 3)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (bs_chord8 == 4)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (bs_chord8 == 5)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (bs_chord8 == 6)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (bs_chord8 == 7)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (bs_chord8 == 8)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (bs_chord8 == 9)
        {
            bs_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la guitare de la montagne

        bm_fmod.setParameterByName("GP_Melody", bm_melody);

        if (bm_melody == 1)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (bm_melody == 2)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (bm_melody == 3)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (bm_melody == 4)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (bm_melody == 5)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (bm_melody == 6)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (bm_melody == 7)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (bm_melody == 8)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (bm_melody == 9)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (bm_melody == 10)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (bm_melody == 11)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (bm_melody == 12)
        {
            bm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        bm_ch_fmod.setParameterByName("ChordsNumber", bm_chords);
        bm_ch_fmod.setParameterByName("Chord1", bm_chord1);
        bm_ch_fmod.setParameterByName("Chord2", bm_chord2);
        bm_ch_fmod.setParameterByName("Chord3", bm_chord3);
        bm_ch_fmod.setParameterByName("Chord4", bm_chord4);
        bm_ch_fmod.setParameterByName("Chord5", bm_chord5);
        bm_ch_fmod.setParameterByName("Chord6", bm_chord6);
        bm_ch_fmod.setParameterByName("Chord7", bm_chord7);
        bm_ch_fmod.setParameterByName("Chord8", bm_chord8);

        if (bm_chords == 1)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (bm_chords == 2)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (bm_chords == 3)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (bm_chords == 4)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (bm_chords == 5)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (bm_chords == 6)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (bm_chords == 7)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (bm_chords == 8)
        {
            bm_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (bm_chord1 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (bm_chord1 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (bm_chord1 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (bm_chord1 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (bm_chord1 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (bm_chord1 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (bm_chord1 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (bm_chord1 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (bm_chord1 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (bm_chord2 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (bm_chord2 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (bm_chord2 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (bm_chord2 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (bm_chord2 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (bm_chord2 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (bm_chord2 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (bm_chord2 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (bm_chord2 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (bm_chord3 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (bm_chord3 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (bm_chord3 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (bm_chord3 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (bm_chord3 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (bm_chord3 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (bm_chord3 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (bm_chord3 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (bm_chord3 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (bm_chord4 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (bm_chord4 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (bm_chord4 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (bm_chord4 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (bm_chord4 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (bm_chord4 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (bm_chord4 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (bm_chord4 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (bm_chord4 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (bm_chord5 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (bm_chord5 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (bm_chord5 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (bm_chord5 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (bm_chord5 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (bm_chord5 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (bm_chord5 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (bm_chord5 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (bm_chord5 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (bm_chord6 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (bm_chord6 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (bm_chord6 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (bm_chord6 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (bm_chord6 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (bm_chord6 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (bm_chord6 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (bm_chord6 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (bm_chord6 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (bm_chord7 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (bm_chord7 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (bm_chord7 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (bm_chord7 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (bm_chord7 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (bm_chord7 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (bm_chord7 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (bm_chord7 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (bm_chord7 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (bm_chord8 == 1)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (bm_chord8 == 2)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (bm_chord8 == 3)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (bm_chord8 == 4)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (bm_chord8 == 5)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (bm_chord8 == 6)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (bm_chord8 == 7)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (bm_chord8 == 8)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (bm_chord8 == 9)
        {
            bm_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la flute de la plaine

        fp_fmod.setParameterByName("GP_Melody", fp_melody);

        if (fp_melody == 1)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (fp_melody == 2)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (fp_melody == 3)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (fp_melody == 4)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (fp_melody == 5)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (fp_melody == 6)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (fp_melody == 7)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (fp_melody == 8)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (fp_melody == 9)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (fp_melody == 10)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (fp_melody == 11)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (fp_melody == 12)
        {
            fp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        fp_ch_fmod.setParameterByName("ChordsNumber", fp_chords);
        fp_ch_fmod.setParameterByName("Chord1", fp_chord1);
        fp_ch_fmod.setParameterByName("Chord2", fp_chord2);
        fp_ch_fmod.setParameterByName("Chord3", fp_chord3);
        fp_ch_fmod.setParameterByName("Chord4", fp_chord4);
        fp_ch_fmod.setParameterByName("Chord5", fp_chord5);
        fp_ch_fmod.setParameterByName("Chord6", fp_chord6);
        fp_ch_fmod.setParameterByName("Chord7", fp_chord7);
        fp_ch_fmod.setParameterByName("Chord8", fp_chord8);

        if (fp_chords == 1)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (fp_chords == 2)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (fp_chords == 3)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (fp_chords == 4)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (fp_chords == 5)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (fp_chords == 6)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (fp_chords == 7)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (fp_chords == 8)
        {
            fp_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (fp_chord1 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (fp_chord1 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (fp_chord1 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (fp_chord1 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (fp_chord1 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (fp_chord1 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (fp_chord1 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (fp_chord1 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (fp_chord1 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (fp_chord2 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (fp_chord2 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (fp_chord2 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (fp_chord2 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (fp_chord2 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (fp_chord2 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (fp_chord2 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (fp_chord2 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (fp_chord2 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (fp_chord3 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (fp_chord3 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (fp_chord3 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (fp_chord3 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (fp_chord3 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (fp_chord3 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (fp_chord3 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (fp_chord3 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (fp_chord3 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (fp_chord4 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (fp_chord4 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (fp_chord4 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (fp_chord4 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (fp_chord4 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (fp_chord4 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (fp_chord4 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (fp_chord4 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (fp_chord4 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (fp_chord5 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (fp_chord5 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (fp_chord5 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (fp_chord5 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (fp_chord5 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (fp_chord5 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (fp_chord5 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (fp_chord5 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (fp_chord5 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (fp_chord6 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (fp_chord6 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (fp_chord6 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (fp_chord6 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (fp_chord6 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (fp_chord6 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (fp_chord6 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (fp_chord6 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (fp_chord6 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (fp_chord7 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (fp_chord7 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (fp_chord7 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (fp_chord7 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (fp_chord7 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (fp_chord7 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (fp_chord7 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (fp_chord7 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (fp_chord7 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (fp_chord8 == 1)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (fp_chord8 == 2)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (fp_chord8 == 3)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (fp_chord8 == 4)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (fp_chord8 == 5)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (fp_chord8 == 6)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (fp_chord8 == 7)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (fp_chord8 == 8)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (fp_chord8 == 9)
        {
            fp_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }

        // Mélodies de la flute du désert

        fd_fmod.setParameterByName("GP_Melody", fd_melody);

        if (fd_melody == 1)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (fd_melody == 2)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (fd_melody == 3)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (fd_melody == 4)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (fd_melody == 5)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (fd_melody == 6)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (fd_melody == 7)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (fd_melody == 8)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (fd_melody == 9)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (fd_melody == 10)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (fd_melody == 11)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (fd_melody == 12)
        {
            fd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        fd_ch_fmod.setParameterByName("ChordsNumber", fd_chords);
        fd_ch_fmod.setParameterByName("Chord1", fd_chord1);
        fd_ch_fmod.setParameterByName("Chord2", fd_chord2);
        fd_ch_fmod.setParameterByName("Chord3", fd_chord3);
        fd_ch_fmod.setParameterByName("Chord4", fd_chord4);
        fd_ch_fmod.setParameterByName("Chord5", fd_chord5);
        fd_ch_fmod.setParameterByName("Chord6", fd_chord6);
        fd_ch_fmod.setParameterByName("Chord7", fd_chord7);
        fd_ch_fmod.setParameterByName("Chord8", fd_chord8);

        if (fd_chords == 1)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (fd_chords == 2)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (fd_chords == 3)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (fd_chords == 4)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (fd_chords == 5)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (fd_chords == 6)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (fd_chords == 7)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (fd_chords == 8)
        {
            fd_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (fd_chord1 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (fd_chord1 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (fd_chord1 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (fd_chord1 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (fd_chord1 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (fd_chord1 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (fd_chord1 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (fd_chord1 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (fd_chord1 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (fd_chord2 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (fd_chord2 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (fd_chord2 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (fd_chord2 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (fd_chord2 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (fd_chord2 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (fd_chord2 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (fd_chord2 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (fd_chord2 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (fd_chord3 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (fd_chord3 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (fd_chord3 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (fd_chord3 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (fd_chord3 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (fd_chord3 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (fd_chord3 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (fd_chord3 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (fd_chord3 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (fd_chord4 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (fd_chord4 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (fd_chord4 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (fd_chord4 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (fd_chord4 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (fd_chord4 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (fd_chord4 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (fd_chord4 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (fd_chord4 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (fd_chord5 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (fd_chord5 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (fd_chord5 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (fd_chord5 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (fd_chord5 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (fd_chord5 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (fd_chord5 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (fd_chord5 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (fd_chord5 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (fd_chord6 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (fd_chord6 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (fd_chord6 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (fd_chord6 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (fd_chord6 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (fd_chord6 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (fd_chord6 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (fd_chord6 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (fd_chord6 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (fd_chord7 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (fd_chord7 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (fd_chord7 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (fd_chord7 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (fd_chord7 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (fd_chord7 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (fd_chord7 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (fd_chord7 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (fd_chord7 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (fd_chord8 == 1)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (fd_chord8 == 2)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (fd_chord8 == 3)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (fd_chord8 == 4)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (fd_chord8 == 5)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (fd_chord8 == 6)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (fd_chord8 == 7)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (fd_chord8 == 8)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (fd_chord8 == 9)
        {
            fd_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la flute du marais

        fs_fmod.setParameterByName("GP_Melody", fs_melody);

        if (fs_melody == 1)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (fs_melody == 2)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (fs_melody == 3)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (fs_melody == 4)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (fs_melody == 5)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (fs_melody == 6)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (fs_melody == 7)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (fs_melody == 8)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (fs_melody == 9)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (fs_melody == 10)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (fs_melody == 11)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (fs_melody == 12)
        {
            fs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        fs_ch_fmod.setParameterByName("ChordsNumber", fs_chords);
        fs_ch_fmod.setParameterByName("Chord1", fs_chord1);
        fs_ch_fmod.setParameterByName("Chord2", fs_chord2);
        fs_ch_fmod.setParameterByName("Chord3", fs_chord3);
        fs_ch_fmod.setParameterByName("Chord4", fs_chord4);
        fs_ch_fmod.setParameterByName("Chord5", fs_chord5);
        fs_ch_fmod.setParameterByName("Chord6", fs_chord6);
        fs_ch_fmod.setParameterByName("Chord7", fs_chord7);
        fs_ch_fmod.setParameterByName("Chord8", fs_chord8);

        if (fs_chords == 1)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (fs_chords == 2)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (fs_chords == 3)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (fs_chords == 4)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (fs_chords == 5)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (fs_chords == 6)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (fs_chords == 7)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (fs_chords == 8)
        {
            fs_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (fs_chord1 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (fs_chord1 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (fs_chord1 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (fs_chord1 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (fs_chord1 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (fs_chord1 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (fs_chord1 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (fs_chord1 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (fs_chord1 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (fs_chord2 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (fs_chord2 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (fs_chord2 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (fs_chord2 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (fs_chord2 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (fs_chord2 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (fs_chord2 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (fs_chord2 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (fs_chord2 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (fs_chord3 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (fs_chord3 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (fs_chord3 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (fs_chord3 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (fs_chord3 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (fs_chord3 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (fs_chord3 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (fs_chord3 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (fs_chord3 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (fs_chord4 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (fs_chord4 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (fs_chord4 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (fs_chord4 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (fs_chord4 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (fs_chord4 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (fs_chord4 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (fs_chord4 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (fs_chord4 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (fs_chord5 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (fs_chord5 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (fs_chord5 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (fs_chord5 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (fs_chord5 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (fs_chord5 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (fs_chord5 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (fs_chord5 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (fs_chord5 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (fs_chord6 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (fs_chord6 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (fs_chord6 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (fs_chord6 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (fs_chord6 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (fs_chord6 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (fs_chord6 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (fs_chord6 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (fs_chord6 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (fs_chord7 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (fs_chord7 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (fs_chord7 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (fs_chord7 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (fs_chord7 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (fs_chord7 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (fs_chord7 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (fs_chord7 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (fs_chord7 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (fs_chord8 == 1)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (fs_chord8 == 2)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (fs_chord8 == 3)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (fs_chord8 == 4)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (fs_chord8 == 5)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (fs_chord8 == 6)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (fs_chord8 == 7)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (fs_chord8 == 8)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (fs_chord8 == 9)
        {
            fs_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies de la flute de la montagne

        fm_fmod.setParameterByName("GP_Melody", fm_melody);

        if (fm_melody == 1)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (fm_melody == 2)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (fm_melody == 3)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (fm_melody == 4)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (fm_melody == 5)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (fm_melody == 6)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (fm_melody == 7)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (fm_melody == 8)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (fm_melody == 9)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (fm_melody == 10)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (fm_melody == 11)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (fm_melody == 12)
        {
            fm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        fm_ch_fmod.setParameterByName("ChordsNumber", fm_chords);
        fm_ch_fmod.setParameterByName("Chord1", fm_chord1);
        fm_ch_fmod.setParameterByName("Chord2", fm_chord2);
        fm_ch_fmod.setParameterByName("Chord3", fm_chord3);
        fm_ch_fmod.setParameterByName("Chord4", fm_chord4);
        fm_ch_fmod.setParameterByName("Chord5", fm_chord5);
        fm_ch_fmod.setParameterByName("Chord6", fm_chord6);
        fm_ch_fmod.setParameterByName("Chord7", fm_chord7);
        fm_ch_fmod.setParameterByName("Chord8", fm_chord8);

        if (fm_chords == 1)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (fm_chords == 2)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (fm_chords == 3)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (fm_chords == 4)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (fm_chords == 5)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (fm_chords == 6)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (fm_chords == 7)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (fm_chords == 8)
        {
            fm_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (fm_chord1 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (fm_chord1 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (fm_chord1 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (fm_chord1 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (fm_chord1 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (fm_chord1 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (fm_chord1 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (fm_chord1 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (fm_chord1 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (fm_chord2 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (fm_chord2 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (fm_chord2 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (fm_chord2 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (fm_chord2 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (fm_chord2 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (fm_chord2 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (fm_chord2 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (fm_chord2 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (fm_chord3 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (fm_chord3 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (fm_chord3 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (fm_chord3 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (fm_chord3 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (fm_chord3 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (fm_chord3 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (fm_chord3 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (fm_chord3 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (fm_chord4 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (fm_chord4 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (fm_chord4 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (fm_chord4 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (fm_chord4 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (fm_chord4 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (fm_chord4 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (fm_chord4 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (fm_chord4 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (fm_chord5 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (fm_chord5 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (fm_chord5 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (fm_chord5 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (fm_chord5 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (fm_chord5 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (fm_chord5 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (fm_chord5 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (fm_chord5 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (fm_chord6 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (fm_chord6 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (fm_chord6 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (fm_chord6 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (fm_chord6 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (fm_chord6 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (fm_chord6 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (fm_chord6 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (fm_chord6 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (fm_chord7 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (fm_chord7 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (fm_chord7 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (fm_chord7 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (fm_chord7 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (fm_chord7 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (fm_chord7 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (fm_chord7 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (fm_chord7 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (fm_chord8 == 1)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (fm_chord8 == 2)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (fm_chord8 == 3)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (fm_chord8 == 4)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (fm_chord8 == 5)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (fm_chord8 == 6)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (fm_chord8 == 7)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (fm_chord8 == 8)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (fm_chord8 == 9)
        {
            fm_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }



        // Mélodies du violon de la plaine

        vp_fmod.setParameterByName("GP_Melody", vp_melody);

        if (vp_melody == 1)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (vp_melody == 2)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (vp_melody == 3)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (vp_melody == 4)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (vp_melody == 5)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (vp_melody == 6)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (vp_melody == 7)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (vp_melody == 8)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (vp_melody == 9)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (vp_melody == 10)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (vp_melody == 11)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (vp_melody == 12)
        {
            vp_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        vp_ch_fmod.setParameterByName("ChordsNumber", vp_chords);
        vp_ch_fmod.setParameterByName("Chord1", vp_chord1);
        vp_ch_fmod.setParameterByName("Chord2", vp_chord2);
        vp_ch_fmod.setParameterByName("Chord3", vp_chord3);
        vp_ch_fmod.setParameterByName("Chord4", vp_chord4);
        vp_ch_fmod.setParameterByName("Chord5", vp_chord5);
        vp_ch_fmod.setParameterByName("Chord6", vp_chord6);
        vp_ch_fmod.setParameterByName("Chord7", vp_chord7);
        vp_ch_fmod.setParameterByName("Chord8", vp_chord8);

        if (vp_chords == 1)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (vp_chords == 2)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (vp_chords == 3)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (vp_chords == 4)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (vp_chords == 5)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (vp_chords == 6)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (vp_chords == 7)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (vp_chords == 8)
        {
            vp_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (vp_chord1 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (vp_chord1 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (vp_chord1 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (vp_chord1 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (vp_chord1 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (vp_chord1 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (vp_chord1 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (vp_chord1 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (vp_chord1 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (vp_chord2 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (vp_chord2 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (vp_chord2 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (vp_chord2 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (vp_chord2 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (vp_chord2 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (vp_chord2 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (vp_chord2 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (vp_chord2 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (vp_chord3 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (vp_chord3 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (vp_chord3 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (vp_chord3 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (vp_chord3 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (vp_chord3 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (vp_chord3 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (vp_chord3 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (vp_chord3 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (vp_chord4 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (vp_chord4 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (vp_chord4 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (vp_chord4 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (vp_chord4 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (vp_chord4 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (vp_chord4 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (vp_chord4 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (vp_chord4 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (vp_chord5 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (vp_chord5 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (vp_chord5 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (vp_chord5 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (vp_chord5 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (vp_chord5 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (vp_chord5 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (vp_chord5 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (vp_chord5 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (vp_chord6 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (vp_chord6 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (vp_chord6 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (vp_chord6 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (vp_chord6 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (vp_chord6 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (vp_chord6 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (vp_chord6 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (vp_chord6 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (vp_chord7 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (vp_chord7 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (vp_chord7 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (vp_chord7 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (vp_chord7 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (vp_chord7 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (vp_chord7 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (vp_chord7 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (vp_chord7 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (vp_chord8 == 1)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (vp_chord8 == 2)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (vp_chord8 == 3)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (vp_chord8 == 4)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (vp_chord8 == 5)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (vp_chord8 == 6)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (vp_chord8 == 7)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (vp_chord8 == 8)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (vp_chord8 == 9)
        {
            vp_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }

        // Mélodies du violon du désert

        vd_fmod.setParameterByName("GP_Melody", vd_melody);

        if (vd_melody == 1)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (vd_melody == 2)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (vd_melody == 3)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (vd_melody == 4)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (vd_melody == 5)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (vd_melody == 6)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (vd_melody == 7)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (vd_melody == 8)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (vd_melody == 9)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (vd_melody == 10)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (vd_melody == 11)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (vd_melody == 12)
        {
            vd_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        vd_ch_fmod.setParameterByName("ChordsNumber", vd_chords);
        vd_ch_fmod.setParameterByName("Chord1", vd_chord1);
        vd_ch_fmod.setParameterByName("Chord2", vd_chord2);
        vd_ch_fmod.setParameterByName("Chord3", vd_chord3);
        vd_ch_fmod.setParameterByName("Chord4", vd_chord4);
        vd_ch_fmod.setParameterByName("Chord5", vd_chord5);
        vd_ch_fmod.setParameterByName("Chord6", vd_chord6);
        vd_ch_fmod.setParameterByName("Chord7", vd_chord7);
        vd_ch_fmod.setParameterByName("Chord8", vd_chord8);

        if (vd_chords == 1)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (vd_chords == 2)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (vd_chords == 3)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (vd_chords == 4)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (vd_chords == 5)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (vd_chords == 6)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (vd_chords == 7)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (vd_chords == 8)
        {
            vd_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (vd_chord1 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (vd_chord1 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (vd_chord1 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (vd_chord1 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (vd_chord1 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (vd_chord1 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (vd_chord1 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (vd_chord1 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (vd_chord1 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (vd_chord2 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (vd_chord2 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (vd_chord2 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (vd_chord2 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (vd_chord2 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (vd_chord2 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (vd_chord2 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (vd_chord2 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (vd_chord2 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (vd_chord3 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (vd_chord3 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (vd_chord3 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (vd_chord3 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (vd_chord3 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (vd_chord3 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (vd_chord3 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (vd_chord3 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (vd_chord3 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (vd_chord4 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (vd_chord4 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (vd_chord4 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (vd_chord4 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (vd_chord4 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (vd_chord4 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (vd_chord4 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (vd_chord4 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (vd_chord4 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (vd_chord5 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (vd_chord5 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (vd_chord5 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (vd_chord5 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (vd_chord5 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (vd_chord5 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (vd_chord5 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (vd_chord5 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (vd_chord5 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (vd_chord6 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (vd_chord6 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (vd_chord6 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (vd_chord6 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (vd_chord6 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (vd_chord6 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (vd_chord6 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (vd_chord6 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (vd_chord6 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (vd_chord7 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (vd_chord7 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (vd_chord7 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (vd_chord7 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (vd_chord7 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (vd_chord7 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (vd_chord7 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (vd_chord7 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (vd_chord7 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (vd_chord8 == 1)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (vd_chord8 == 2)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (vd_chord8 == 3)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (vd_chord8 == 4)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (vd_chord8 == 5)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (vd_chord8 == 6)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (vd_chord8 == 7)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (vd_chord8 == 8)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (vd_chord8 == 9)
        {
            vd_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies du violon du marais

        vs_fmod.setParameterByName("GP_Melody", vs_melody);

        if (vs_melody == 1)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (vs_melody == 2)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (vs_melody == 3)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (vs_melody == 4)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (vs_melody == 5)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (vs_melody == 6)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (vs_melody == 7)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (vs_melody == 8)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (vs_melody == 9)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (vs_melody == 10)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (vs_melody == 11)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (vs_melody == 12)
        {
            vs_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        vs_ch_fmod.setParameterByName("ChordsNumber", vs_chords);
        vs_ch_fmod.setParameterByName("Chord1", vs_chord1);
        vs_ch_fmod.setParameterByName("Chord2", vs_chord2);
        vs_ch_fmod.setParameterByName("Chord3", vs_chord3);
        vs_ch_fmod.setParameterByName("Chord4", vs_chord4);
        vs_ch_fmod.setParameterByName("Chord5", vs_chord5);
        vs_ch_fmod.setParameterByName("Chord6", vs_chord6);
        vs_ch_fmod.setParameterByName("Chord7", vs_chord7);
        vs_ch_fmod.setParameterByName("Chord8", vs_chord8);

        if (vs_chords == 1)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (vs_chords == 2)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (vs_chords == 3)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (vs_chords == 4)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (vs_chords == 5)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (vs_chords == 6)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (vs_chords == 7)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (vs_chords == 8)
        {
            vs_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (vs_chord1 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (vs_chord1 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (vs_chord1 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (vs_chord1 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (vs_chord1 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (vs_chord1 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (vs_chord1 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (vs_chord1 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (vs_chord1 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (vs_chord2 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (vs_chord2 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (vs_chord2 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (vs_chord2 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (vs_chord2 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (vs_chord2 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (vs_chord2 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (vs_chord2 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (vs_chord2 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (vs_chord3 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (vs_chord3 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (vs_chord3 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (vs_chord3 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (vs_chord3 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (vs_chord3 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (vs_chord3 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (vs_chord3 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (vs_chord3 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (vs_chord4 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (vs_chord4 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (vs_chord4 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (vs_chord4 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (vs_chord4 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (vs_chord4 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (vs_chord4 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (vs_chord4 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (vs_chord4 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (vs_chord5 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (vs_chord5 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (vs_chord5 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (vs_chord5 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (vs_chord5 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (vs_chord5 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (vs_chord5 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (vs_chord5 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (vs_chord5 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (vs_chord6 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (vs_chord6 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (vs_chord6 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (vs_chord6 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (vs_chord6 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (vs_chord6 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (vs_chord6 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (vs_chord6 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (vs_chord6 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (vs_chord7 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (vs_chord7 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (vs_chord7 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (vs_chord7 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (vs_chord7 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (vs_chord7 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (vs_chord7 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (vs_chord7 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (vs_chord7 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (vs_chord8 == 1)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (vs_chord8 == 2)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (vs_chord8 == 3)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (vs_chord8 == 4)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (vs_chord8 == 5)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (vs_chord8 == 6)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (vs_chord8 == 7)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (vs_chord8 == 8)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (vs_chord8 == 9)
        {
            vs_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }


        // Mélodies du violon de la montagne

        vm_fmod.setParameterByName("GP_Melody", vm_melody);

        if (vm_melody == 1)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 1");
        }
        if (vm_melody == 2)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 2");
        }
        if (vm_melody == 3)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 3");
        }
        if (vm_melody == 4)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 4");
        }
        if (vm_melody == 5)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 5");
        }
        if (vm_melody == 6)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 6");
        }
        if (vm_melody == 7)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 7");
        }
        if (vm_melody == 8)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 8");
        }
        if (vm_melody == 9)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 9");
        }
        if (vm_melody == 10)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 10");
        }
        if (vm_melody == 11)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 11");
        }
        if (vm_melody == 12)
        {
            vm_fmod.setParameterByNameWithLabel("GP_Melody", "Melody 12");
        }

        vm_ch_fmod.setParameterByName("ChordsNumber", vm_chords);
        vm_ch_fmod.setParameterByName("Chord1", vm_chord1);
        vm_ch_fmod.setParameterByName("Chord2", vm_chord2);
        vm_ch_fmod.setParameterByName("Chord3", vm_chord3);
        vm_ch_fmod.setParameterByName("Chord4", vm_chord4);
        vm_ch_fmod.setParameterByName("Chord5", vm_chord5);
        vm_ch_fmod.setParameterByName("Chord6", vm_chord6);
        vm_ch_fmod.setParameterByName("Chord7", vm_chord7);
        vm_ch_fmod.setParameterByName("Chord8", vm_chord8);

        if (vm_chords == 1)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 1);
        }
        if (vm_chords == 2)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 2);
        }
        if (vm_chords == 3)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 3);
        }
        if (vm_chords == 4)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 4);
        }
        if (vm_chords == 5)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 5);
        }
        if (vm_chords == 6)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 6);
        }
        if (vm_chords == 7)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 7);
        }
        if (vm_chords == 8)
        {
            vm_ch_fmod.setParameterByName("ChordsNumber", 8);
        }

        if (vm_chord1 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "0 notes");
        }
        if (vm_chord1 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "2 notes");
        }
        if (vm_chord1 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "3 notes");
        }
        if (vm_chord1 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "4 notes");
        }
        if (vm_chord1 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "5 notes");
        }
        if (vm_chord1 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "6 notes");
        }
        if (vm_chord1 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "7 notes");
        }
        if (vm_chord1 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "8 notes");
        }
        if (vm_chord1 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord1", "9 notes");
        }

        if (vm_chord2 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "0 notes");
        }
        if (vm_chord2 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "2 notes");
        }
        if (vm_chord2 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "3 notes");
        }
        if (vm_chord2 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "4 notes");
        }
        if (vm_chord2 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "5 notes");
        }
        if (vm_chord2 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "6 notes");
        }
        if (vm_chord2 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "7 notes");
        }
        if (vm_chord2 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "8 notes");
        }
        if (vm_chord2 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord2", "9 notes");
        }

        if (vm_chord3 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "0 notes");
        }
        if (vm_chord3 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "2 notes");
        }
        if (vm_chord3 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "3 notes");
        }
        if (vm_chord3 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "4 notes");
        }
        if (vm_chord3 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "5 notes");
        }
        if (vm_chord3 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "6 notes");
        }
        if (vm_chord3 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "7 notes");
        }
        if (vm_chord3 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "8 notes");
        }
        if (vm_chord3 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord3", "9 notes");
        }

        if (vm_chord4 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "0 notes");
        }
        if (vm_chord4 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "2 notes");
        }
        if (vm_chord4 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "3 notes");
        }
        if (vm_chord4 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "4 notes");
        }
        if (vm_chord4 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "5 notes");
        }
        if (vm_chord4 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "6 notes");
        }
        if (vm_chord4 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "7 notes");
        }
        if (vm_chord4 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "8 notes");
        }
        if (vm_chord4 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord4", "9 notes");
        }

        if (vm_chord5 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "0 notes");
        }
        if (vm_chord5 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "2 notes");
        }
        if (vm_chord5 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "3 notes");
        }
        if (vm_chord5 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "4 notes");
        }
        if (vm_chord5 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "5 notes");
        }
        if (vm_chord5 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "6 notes");
        }
        if (vm_chord5 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "7 notes");
        }
        if (vm_chord5 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "8 notes");
        }
        if (vm_chord5 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord5", "9 notes");
        }

        if (vm_chord6 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "0 notes");
        }
        if (vm_chord6 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "2 notes");
        }
        if (vm_chord6 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "3 notes");
        }
        if (vm_chord6 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "4 notes");
        }
        if (vm_chord6 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "5 notes");
        }
        if (vm_chord6 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "6 notes");
        }
        if (vm_chord6 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "7 notes");
        }
        if (vm_chord6 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "8 notes");
        }
        if (vm_chord6 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord6", "9 notes");
        }

        if (vm_chord7 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "0 notes");
        }
        if (vm_chord7 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "2 notes");
        }
        if (vm_chord7 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "3 notes");
        }
        if (vm_chord7 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "4 notes");
        }
        if (vm_chord7 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "5 notes");
        }
        if (vm_chord7 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "6 notes");
        }
        if (vm_chord7 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "7 notes");
        }
        if (vm_chord7 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "8 notes");
        }
        if (vm_chord7 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord7", "9 notes");
        }

        if (vm_chord8 == 1)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "0 notes");
        }
        if (vm_chord8 == 2)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "2 notes");
        }
        if (vm_chord8 == 3)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "3 notes");
        }
        if (vm_chord8 == 4)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "4 notes");
        }
        if (vm_chord8 == 5)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "5 notes");
        }
        if (vm_chord8 == 6)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "6 notes");
        }
        if (vm_chord8 == 7)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "7 notes");
        }
        if (vm_chord8 == 8)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "8 notes");
        }
        if (vm_chord8 == 9)
        {
            vm_ch_fmod.setParameterByNameWithLabel("Chord8", "9 notes");
        }

    }

}
