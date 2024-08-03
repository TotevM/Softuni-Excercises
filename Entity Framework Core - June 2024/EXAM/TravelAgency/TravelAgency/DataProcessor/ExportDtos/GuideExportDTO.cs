﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelAgency.DataProcessor.ExportDtos
{
    [XmlType("Guide")]
    public class GuideExportDTO
    {
        [XmlElement("FullName")]
        public string FullName { get; set; }

        [XmlArray("TourPackages")]
        public TourPackageDTO[] TourPackages { get; set; }

    }
}
