using System.Collections.Generic;
using Phoogle.Auditing.Dto;
using Phoogle.Dto;

namespace Phoogle.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
