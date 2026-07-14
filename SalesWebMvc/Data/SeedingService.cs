using SalesWebMvc.Models;
using SalesWebMvc.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.SwmDepartment.Any() ||
                _context.SwmSeller.Any() ||
                _context.SwmSalesRecord.Any())
            {
                return; // DB has been seeded
            }

            SwmDepartment d1 = new SwmDepartment(1, "Computers");
            SwmDepartment d2 = new SwmDepartment(2, "Electronics");
            SwmDepartment d3 = new SwmDepartment(3, "Fashion");
            SwmDepartment d4 = new SwmDepartment(4, "Books");

            SwmSeller s1 = new SwmSeller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            SwmSeller s2 = new SwmSeller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            SwmSeller s3 = new SwmSeller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            SwmSeller s4 = new SwmSeller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            SwmSeller s5 = new SwmSeller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            SwmSeller s6 = new SwmSeller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SwmSalesRecord r1 = new SwmSalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SwmSalesStatus.Billed, s1);
            SwmSalesRecord r2 = new SwmSalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SwmSalesStatus.Billed, s5);
            SwmSalesRecord r3 = new SwmSalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SwmSalesStatus.Canceled, s4);
            SwmSalesRecord r4 = new SwmSalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SwmSalesStatus.Billed, s1);
            SwmSalesRecord r5 = new SwmSalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SwmSalesStatus.Billed, s3);
            SwmSalesRecord r6 = new SwmSalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SwmSalesStatus.Billed, s1);
            SwmSalesRecord r7 = new SwmSalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SwmSalesStatus.Billed, s2);
            SwmSalesRecord r8 = new SwmSalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SwmSalesStatus.Billed, s4);
            SwmSalesRecord r9 = new SwmSalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SwmSalesStatus.Pending, s6);
            SwmSalesRecord r10 = new SwmSalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SwmSalesStatus.Billed, s6);
            SwmSalesRecord r11 = new SwmSalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SwmSalesStatus.Billed, s2);
            SwmSalesRecord r12 = new SwmSalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SwmSalesStatus.Pending, s3);
            SwmSalesRecord r13 = new SwmSalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SwmSalesStatus.Billed, s4);
            SwmSalesRecord r14 = new SwmSalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SwmSalesStatus.Billed, s5);
            SwmSalesRecord r15 = new SwmSalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SwmSalesStatus.Billed, s1);
            SwmSalesRecord r16 = new SwmSalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SwmSalesStatus.Billed, s4);
            SwmSalesRecord r17 = new SwmSalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SwmSalesStatus.Billed, s1);
            SwmSalesRecord r18 = new SwmSalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SwmSalesStatus.Billed, s3);
            SwmSalesRecord r19 = new SwmSalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SwmSalesStatus.Billed, s5);
            SwmSalesRecord r20 = new SwmSalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SwmSalesStatus.Billed, s6);
            SwmSalesRecord r21 = new SwmSalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SwmSalesStatus.Billed, s2);
            SwmSalesRecord r22 = new SwmSalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SwmSalesStatus.Billed, s4);
            SwmSalesRecord r23 = new SwmSalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SwmSalesStatus.Canceled, s2);
            SwmSalesRecord r24 = new SwmSalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SwmSalesStatus.Billed, s5);
            SwmSalesRecord r25 = new SwmSalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SwmSalesStatus.Billed, s3);
            SwmSalesRecord r26 = new SwmSalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SwmSalesStatus.Billed, s4);
            SwmSalesRecord r27 = new SwmSalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SwmSalesStatus.Pending, s1);
            SwmSalesRecord r28 = new SwmSalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SwmSalesStatus.Billed, s3);
            SwmSalesRecord r29 = new SwmSalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SwmSalesStatus.Billed, s5);
            SwmSalesRecord r30 = new SwmSalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SwmSalesStatus.Billed, s2);

            _context.SwmDepartment.AddRange(d1, d2, d3, d4);

            _context.SwmSeller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SwmSalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
