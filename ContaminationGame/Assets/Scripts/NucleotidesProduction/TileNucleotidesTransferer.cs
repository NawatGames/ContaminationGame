using UnityEngine;

namespace NucleotidesProduction
{
    /// <summary>
    ///  Transfere os nucleotideos armazenados do tile storage para o player info 
    /// </summary>
    public class TileNucleotidesTransferer : MonoBehaviour
    {
        
        [SerializeField] private NucleotideTileStorage nucleotidesTileStorage;
        [SerializeField] private PlayerInfo playerInfo;

        public void TransferNucleotides()
        {
            var currentStorage = nucleotidesTileStorage.CurrentStorage;
            playerInfo.AddPlayerNucleotides(currentStorage);
            nucleotidesTileStorage.RemoveFromCurrentStorage(currentStorage);
        }
    }
}
