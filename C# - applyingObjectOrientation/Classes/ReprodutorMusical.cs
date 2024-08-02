

namespace C____applyingObjectOrientation.Classes;

class ReprodutorMusical
{
    public bool Reprodução { get; set; }
    public bool Pause { get; }
    public bool Avanco { get; set; }
    public int VolumeControl{ get; set; }

    public ReprodutorMusical(bool reproducao, bool pause, bool avanco, int volume )
    {
        Reprodução = reproducao;
        Pause = pause;
        Avanco = avanco;
    }
}
