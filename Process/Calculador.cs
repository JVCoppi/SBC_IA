using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class Calculador
    {

        public List<Caso> calculoSimilaridadeGlobal(Caso casoProb)
        {
            Pegador pegador = new Pegador();
            List<Caso> casos = new List<Caso>();
            casos = pegador.listarTodosCasos();
            float sarea_damaged;
            float scanker_lesion;
            float scrop_hist;
            float sdate;
            float sexternal_decay;
            float sfruit_spots;
            float sfruiting_bodies;
            float sfruit_pods;
            float sgermination;
            float shail;
            float sint_discolor;
            float sleaf_malf;
            float sleaf_mild;
            float sleaf_shread;
            float sleafspots_halo;
            float sleafspot_size;
            float sleafspots_marg;
            float sleaves;
            float slodging;
            float smold_growth;
            float smycelium;
            float splant_growth;
            float splant_stand;
            float sprecip;
            float sroots;
            float ssclerotia;
            float sseed;
            float sseed_discolor;
            float sseed_size;
            float sseed_tmt;
            float sseverity;
            float sshriveling;
            float sstem;
            float sstem_cankers;
            float stemp;

            foreach (Caso c in casos)
            {
                if (pegador.getSimilaridade("area-damaged") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.area_damaged, "area-damaged");
                    valorC = pegador.getValor(c.area_damaged, "area-damaged");
                    maior = pegador.getMaior("area-damaged");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if(valorC == -1 || valorP == -1)
                    {
                        sarea_damaged = 0;
                    }
                    else
                    {
                        sarea_damaged = result;
                    }
                }
                else
                {
                    sarea_damaged = pegador.verificaIgual(casoProb.area_damaged, c.area_damaged);
                }

                if (pegador.getSimilaridade("canker-lesion") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.canker_lesion, "canker-lesion");
                    valorC = pegador.getValor(c.canker_lesion, "canker-lesion");
                    maior = pegador.getMaior("canker-lesion");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        scanker_lesion = 0;
                    }
                    else
                    {
                        scanker_lesion = result;
                    }
                    
                }
                else
                {
                    scanker_lesion = pegador.verificaIgual(casoProb.canker_lesion, c.canker_lesion);
                }

                if (pegador.getSimilaridade("crop-hist") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.crop_hist, "crop-hist");
                    valorC = pegador.getValor(c.crop_hist, "crop-hist");
                    maior = pegador.getMaior("crop-hist");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        scrop_hist = 0;
                    }
                    else
                    {
                        scrop_hist = result;
                    }
                    
                }
                else
                {
                    scrop_hist = pegador.verificaIgual(casoProb.crop_hist, c.crop_hist);
                }

                if (pegador.getSimilaridade("date") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.date, "date");
                    valorC = pegador.getValor(c.date, "date");
                    maior = pegador.getMaior("date");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sdate = 0;
                    }
                    else
                    {
                        sdate = result;
                    }
                    
                }
                else
                {
                    sdate = pegador.verificaIgual(casoProb.date, c.date);
                }

                if (pegador.getSimilaridade("external decay") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.external_decay, "external decay");
                    valorC = pegador.getValor(c.external_decay, "external decay");
                    maior = pegador.getMaior("external decay");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sexternal_decay = 0;
                    }
                    else
                    {
                        sexternal_decay = result;
                    }
                    
                }
                else
                {
                    sexternal_decay = pegador.verificaIgual(casoProb.external_decay, c.external_decay);
                }

                if (pegador.getSimilaridade("fruit spots") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.fruit_spots, "fruit spots");
                    valorC = pegador.getValor(c.fruit_spots, "fruit spots");
                    maior = pegador.getMaior("fruit spots");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sfruit_spots = 0;
                    }
                    else
                    {
                        sfruit_spots = result;
                    }
                    
                }
                else
                {
                    sfruit_spots = pegador.verificaIgual(casoProb.fruit_spots, c.fruit_spots);
                }

                if (pegador.getSimilaridade("fruiting-bodies") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.fruiting_bodies, "fruiting-bodies");
                    valorC = pegador.getValor(c.fruiting_bodies, "fruiting-bodies");
                    maior = pegador.getMaior("fruiting-bodies");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));

                    if (valorC == -1 || valorP == -1)
                    {
                        sfruiting_bodies = 0;
                    }
                    else
                    {
                        sfruiting_bodies = result;
                    }
                    
                }
                else
                {
                    sfruiting_bodies = pegador.verificaIgual(casoProb.fruiting_bodies, c.fruiting_bodies);
                }

                if (pegador.getSimilaridade("fruit-pods") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.fruit_pods, "fruit-pods");
                    valorC = pegador.getValor(c.fruit_pods, "fruit-pods");
                    maior = pegador.getMaior("fruit-pods");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sfruit_pods = 0;
                    }
                    else
                    {
                        sfruit_pods = result;
                    }
                    
                }
                else
                {
                    sfruit_pods = pegador.verificaIgual(casoProb.fruit_pods, c.fruit_pods);
                }

                if (pegador.getSimilaridade("germination") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.germination, "germination");
                    valorC = pegador.getValor(c.germination, "germination");
                    maior = pegador.getMaior("germination");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sgermination = 0;
                    }
                    else
                    {
                        sgermination = result;
                    }
                    
                }
                else
                {
                    sgermination = pegador.verificaIgual(casoProb.germination, c.germination);
                }
            
                if (pegador.getSimilaridade("hail") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.hail, "hail");
                    valorC = pegador.getValor(c.hail, "hail");
                    maior = pegador.getMaior("hail");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        shail = 0;
                    }
                    else
                    {
                        shail = result;
                    }
                    
                }
                else
                {
                    shail = pegador.verificaIgual(casoProb.hail, c.hail);
                }

                if (pegador.getSimilaridade("int-discolor") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.int_discolor, "int-discolor");
                    valorC = pegador.getValor(c.int_discolor, "int-discolor");
                    maior = pegador.getMaior("int-discolor");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sint_discolor = 0;
                    }
                    else
                    {
                        sint_discolor = result;
                    }
                    
                }
                else
                {
                    sint_discolor = pegador.verificaIgual(casoProb.int_discolor, c.int_discolor);
                }

                if (pegador.getSimilaridade("leaf-malf") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leaf_malf, "leaf-malf");
                    valorC = pegador.getValor(c.leaf_malf, "leaf-malf");
                    maior = pegador.getMaior("leaf-malf");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleaf_malf = 0;
                    }
                    else
                    {
                        sleaf_malf = result;
                    }
                    
                }
                else
                {
                    sleaf_malf = pegador.verificaIgual(casoProb.leaf_malf, c.leaf_malf);
                }

                if (pegador.getSimilaridade("leaf-mild") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leaf_mild, "leaf-mild");
                    valorC = pegador.getValor(c.leaf_mild, "leaf-mild");
                    maior = pegador.getMaior("leaf-mild");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleaf_mild = 0;
                    }
                    else
                    {
                        sleaf_mild = result;
                    }
                    
                }
                else
                {
                    sleaf_mild = pegador.verificaIgual(casoProb.leaf_mild, c.leaf_mild);
                }

                if (pegador.getSimilaridade("leaf-shread") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leaf_shread, "leaf-shread");
                    valorC = pegador.getValor(c.leaf_shread, "leaf-shread");
                    maior = pegador.getMaior("leaf-shread");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleaf_shread = 0;
                    }
                    else
                    {
                        sleaf_shread = result;
                    }
                    
                }
                else
                {
                    sleaf_shread = pegador.verificaIgual(casoProb.leaf_shread, c.leaf_shread);
                }

                if (pegador.getSimilaridade("leafspots-halo") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leafspots_halo, "leafspots-halo");
                    valorC = pegador.getValor(c.leafspots_halo, "leafspots-halo");
                    maior = pegador.getMaior("leafspots-halo");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleafspots_halo = 0;
                    }
                    else
                    {
                        sleafspots_halo = result;
                    }
                    
                }
                else
                {
                    sleafspots_halo = pegador.verificaIgual(casoProb.leafspots_halo, c.leafspots_halo);
                }

                if (pegador.getSimilaridade("leafspot-size") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leafspot_size, "leafspot-size");
                    valorC = pegador.getValor(c.leafspot_size, "leafspot-size");
                    maior = pegador.getMaior("leafspot-size");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleafspot_size = 0;
                    }
                    else
                    {
                        sleafspot_size = result;
                    }
                    
                }
                else
                {
                    sleafspot_size = pegador.verificaIgual(casoProb.leafspot_size, c.leafspot_size);
                }

                if (pegador.getSimilaridade("leafspots-marg") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leafspots_marg, "leafspots-marg");
                    valorC = pegador.getValor(c.leafspots_marg, "leafspots-marg");
                    maior = pegador.getMaior("leafspots-marg");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleafspots_marg = 0;
                    }
                    else
                    {
                        sleafspots_marg = result;
                    }
                    
                }
                else
                {
                    sleafspots_marg = pegador.verificaIgual(casoProb.leafspots_marg, c.leafspots_marg);
                }

                if (pegador.getSimilaridade("leaves") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.leaves, "leaves");
                    valorC = pegador.getValor(c.leaves, "leaves");
                    maior = pegador.getMaior("leaves");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sleaves = 0;
                    }
                    else
                    {
                        sleaves = result;
                    }
                    
                }
                else
                {
                    sleaves = pegador.verificaIgual(casoProb.leaves, c.leaves);
                }

                if (pegador.getSimilaridade("lodging") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.lodging, "lodging");
                    valorC = pegador.getValor(c.lodging, "lodging");
                    maior = pegador.getMaior("lodging");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        slodging = 0;
                    }
                    else
                    {
                        slodging = result;
                    }
                    
                }
                else
                {
                    slodging = pegador.verificaIgual(casoProb.lodging, c.lodging);
                }

                if (pegador.getSimilaridade("mold-growth") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.mold_growth, "mold-growth");
                    valorC = pegador.getValor(c.mold_growth, "mold-growth");
                    maior = pegador.getMaior("mold-growth");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        smold_growth = 0;
                    }
                    else
                    {
                        smold_growth = result;
                    }
                    
                }
                else
                {
                    smold_growth = pegador.verificaIgual(casoProb.mold_growth, c.mold_growth);
                }

                if (pegador.getSimilaridade("mycelium") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.mycelium, "mycelium");
                    valorC = pegador.getValor(c.mycelium, "mycelium");
                    maior = pegador.getMaior("mycelium");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        smycelium = 0;
                    }
                    else
                    {
                        smycelium = result;
                    }
                    
                }
                else
                {
                    smycelium = pegador.verificaIgual(casoProb.mycelium, c.mycelium);
                }

                if (pegador.getSimilaridade("plant-growth") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.plant_growth, "plant-growth");
                    valorC = pegador.getValor(c.plant_growth, "plant-growth");
                    maior = pegador.getMaior("plant-growth");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        splant_growth = 0;
                    }
                    else
                    {
                        splant_growth = result;
                    }
                                    }
                else
                {
                    splant_growth = pegador.verificaIgual(casoProb.plant_growth, c.plant_growth);
                }

                if (pegador.getSimilaridade("plant-stand") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.plant_stand, "plant-stand");
                    valorC = pegador.getValor(c.plant_stand, "plant-stand");
                    maior = pegador.getMaior("plant-stand");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        splant_stand = 0;
                    }
                    else
                    {
                        splant_stand = result;
                    }
                    
                }
                else
                {
                    splant_stand = pegador.verificaIgual(casoProb.plant_stand, c.plant_stand);
                }

                if (pegador.getSimilaridade("precip") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.precip, "precip");
                    valorC = pegador.getValor(c.precip, "precip");
                    maior = pegador.getMaior("precip");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sprecip = 0;
                    }
                    else
                    {
                        sprecip = result;
                    }
                    
                }
                else
                {
                    sprecip = pegador.verificaIgual(casoProb.precip, c.precip);
                }

                if (pegador.getSimilaridade("roots") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.roots, "roots");
                    valorC = pegador.getValor(c.roots, "roots");
                    maior = pegador.getMaior("roots");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sroots = 0;
                    }
                    else
                    {
                        sroots = result;
                    }
                    
                }
                else
                {
                    sroots = pegador.verificaIgual(casoProb.roots, c.roots);
                }

                if (pegador.getSimilaridade("sclerotia") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.sclerotia, "sclerotia");
                    valorC = pegador.getValor(c.sclerotia, "sclerotia");
                    maior = pegador.getMaior("sclerotia");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        ssclerotia = 0;
                    }
                    else
                    {
                        ssclerotia = result;
                    }
                    
                }
                else
                {
                    ssclerotia = pegador.verificaIgual(casoProb.sclerotia, c.sclerotia);
                }

                if (pegador.getSimilaridade("seed") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.seed, "seed");
                    valorC = pegador.getValor(c.seed, "seed");
                    maior = pegador.getMaior("seed");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sseed = 0;
                    }
                    else
                    {
                        sseed = result;
                    }
                    
                }
                else
                {
                    sseed = pegador.verificaIgual(casoProb.seed, c.seed);
                }

                if (pegador.getSimilaridade("seed-discolor") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.seed_discolor, "seed-discolor");
                    valorC = pegador.getValor(c.seed_discolor, "seed-discolor");
                    maior = pegador.getMaior("seed-discolor");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sseed_discolor = 0;
                    }
                    else
                    {
                        sseed_discolor = result;
                    }
                    
                }
                else
                {
                    sseed_discolor = pegador.verificaIgual(casoProb.seed_discolor, c.seed_discolor);
                }

                if (pegador.getSimilaridade("seed-size") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.seed_size, "seed-size");
                    valorC = pegador.getValor(c.seed_size, "seed-size");
                    maior = pegador.getMaior("seed-size");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sseed_size = 0;
                    }
                    else
                    {
                        sseed_size = result;
                    }
                    
                }
                else
                {
                    sseed_size = pegador.verificaIgual(casoProb.seed_size, c.seed_size);
                }

                if (pegador.getSimilaridade("seed-tmt") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.seed_tmt, "seed-tmt");
                    valorC = pegador.getValor(c.seed_tmt, "seed-tmt");
                    maior = pegador.getMaior("seed-tmt");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sseed_tmt = 0;
                    }
                    else
                    {
                        sseed_tmt = result;
                    }
                    
                }
                else
                {
                    sseed_tmt = pegador.verificaIgual(casoProb.seed_tmt, c.seed_tmt);
                }

                if (pegador.getSimilaridade("severity") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.severity, "severity");
                    valorC = pegador.getValor(c.severity, "severity");
                    maior = pegador.getMaior("severity");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sseverity = 0;
                    }
                    else
                    {
                        sseverity = result;
                    }
                    
                }
                else
                {
                    sseverity = pegador.verificaIgual(casoProb.area_damaged, c.area_damaged);
                }

                if (pegador.getSimilaridade("shriveling") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.shriveling, "shriveling");
                    valorC = pegador.getValor(c.shriveling, "shriveling");
                    maior = pegador.getMaior("shriveling");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sshriveling = 0;
                    }
                    else
                    {
                        sshriveling = result;
                    }

                }
                else
                {
                    sshriveling = pegador.verificaIgual(casoProb.shriveling, c.shriveling);
                }

                if (pegador.getSimilaridade("stem") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.stem, "stem");
                    valorC = pegador.getValor(c.stem, "stem");
                    maior = pegador.getMaior("stem");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sstem = 0;
                    }
                    else
                    {
                        sstem = result;
                    }
                    
                }
                else
                {
                    sstem = pegador.verificaIgual(casoProb.stem, c.stem);
                }

                if (pegador.getSimilaridade("stem-cankers") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.stem_cankers, "stem-cankers");
                    valorC = pegador.getValor(c.stem_cankers, "stem-cankers");
                    maior = pegador.getMaior("stem-cankers");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        sstem_cankers = 0;
                    }
                    else
                    {
                        sstem_cankers = result;
                    }
                    
                }
                else
                {
                    sstem_cankers = pegador.verificaIgual(casoProb.stem_cankers, c.stem_cankers);
                }

                if (pegador.getSimilaridade("temp") == "Sim")
                {
                    int valorP, valorC, maior;
                    float valorParcial, result;
                    valorP = pegador.getValor(casoProb.temp, "temp");
                    valorC = pegador.getValor(c.temp, "temp");
                    maior = pegador.getMaior("temp");
                    valorParcial = valorP - valorC;
                    if (valorParcial < 0)
                        valorParcial = valorParcial * -1;
                    result = 1 - (valorParcial / (maior - 0));
                    if (valorC == -1 || valorP == -1)
                    {
                        stemp = 0;
                    }
                    else
                    {
                        stemp = result;
                    }
                    
                }
                else
                {
                    stemp = pegador.verificaIgual(casoProb.temp, c.temp);
                }

                float simiGlobal, aux;
                aux = (sarea_damaged*3) + (scanker_lesion*7) + (scrop_hist*1) + (sdate*2) + (sexternal_decay*7) + (sfruiting_bodies*7) + (sfruit_pods*8) + (sfruit_spots*7) + (sgermination*1) + (shail*3) + (sint_discolor*8) + (sleafspots_halo*6) + (sleafspots_marg*7) + (sleafspot_size*7) + (sleaf_malf*7) + (sleaf_mild*8) + (sleaf_shread*7) + (sleaves*8) + (slodging*6) + (smold_growth*8) + (smycelium*8) + (splant_growth*8) + (splant_stand*5) + (sprecip*6) + (sroots*8) + (ssclerotia*8) + (sseed*7) + (sseed_discolor*7) + (sseed_size*8)+(sseed_tmt*1) + (sseverity*3) + (sshriveling*8) + (sstem*8) + (sstem_cankers*7) + (stemp*4);
                simiGlobal = aux / 214;
                c.SimilaridadeGlobal = simiGlobal;


            }

            return casos;

        }
    }
}