using UnityEngine;

namespace NucleotidesProduction
{
    /// <summary>
    ///  Transfere os nucleotideos armazenados do tile storage para o player info 
    /// </summary>
    public class TileNucleotidesTransferer : MonoBehaviour
    {
        //todo: codigo de autocoletar
        [SerializeField] private NucleotideTileStorage nucleotidesTileStorage;


        public void TransferNucleotides()
        {
            var currentStorage = nucleotidesTileStorage.CurrentStorage;
            PlayerInfo.instance.AddPlayerNucleotides(currentStorage);
            nucleotidesTileStorage.RemoveFromCurrentStorage(currentStorage);
        }
    }
}
