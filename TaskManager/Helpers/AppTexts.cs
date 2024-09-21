using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Helpers
{
    public static class AppTexts
    {
        #region INFO

        public const string InfoMessageTaskAdded = "Tarea agregada con éxito";
        public const string InfoMessageTaskEdited = "Tarea editada con éxito";
        public const string InfoMessageTaskDeleted = "Tarea eliminada con éxito";

        #endregion

        #region WARNINGS

        public const string WarningMessageRequiredFields = "Debe de ingresar los campos obligatorios";

        public const string WarningMessageEmptyDesc = "Por favor ingrese una descripción";
        public const string WarningMessageEmptyState = "Por favor elija un Estado";
        public const string WarningMessageEmptyPriority = "Por favor escoja una Prioridad";
        public const string WarningMessageEmptyDate = "Por favor elija una Fecha de Compromiso";

        public const string WarningMessageDeleteTask = "Está seguro de que quiere eliminar la Tarea?";

        #endregion

        #region ERRORS

        public const string ErrorMessageCreateTask = "No se pudo crear la Tarea";
        public const string ErrorMessageEditTask = "No se pudo editar la Tarea";
        public const string ErrorMessageDeleteTask = "No se pudo eliminar la Tarea";

        public const string ErrorMessageCantUpdateForState = "No se puede editar la Tarea por que se encuentra FINALIZADA";
        public const string ErrorMessageCantDeleteForState = "No se puede eliminar la Tarea por que se encuentra EN PROCESO";

        #endregion

    }
}
