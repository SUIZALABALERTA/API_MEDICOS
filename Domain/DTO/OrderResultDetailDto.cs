namespace Domain.DTO
{
    public class OrderResultDetailDto
    {
        public int Item { get; set; }
        public string IdExamen { get; set; }
        public string examen { get; set; }
        public bool escaneado { get; set; }
        public bool validado { get; set; }
        public bool reproceso { get; set; }
        public bool impreso { get; set; }
        public bool FlagPerfil { get; set; }
        public string CodigoAlfanumerico { get; set; }

    }
}
