using System;

namespace Library {
    public static class ValidationUtils {
        public static bool IsValidString(string s) {
            return !string.IsNullOrEmpty(s);
        }

        public static bool IsValidDate(DateTime fecha) {
            return fecha > new DateTime(2015, 1, 1) && fecha < new DateTime(2025, 1, 1);
        }
    }
}