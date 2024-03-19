using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkContourHelper
	/// </summary>
	/// <remarks>
	///  A utility class used by various contour filters
	///
	/// This is a simple utility class that can be used by various contour filters to
	/// produce either triangles and/or polygons based on the outputTriangles parameter.
	/// If outputTriangles is set to true, trisEstimatedSize is used to allocate memory
	/// for temporary triangles created by contouring before merging them.
	/// If outputTriangles is set to false, contouring triangles are outputted and
	/// trisEstimatedSize is not used.
	///
	/// When working with multidimensional dataset, it is needed to process cells
	/// from low to high dimensions.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourGrid vtkCutter vtkContourFilter
	/// </seealso>
	// Token: 0x02000952 RID: 2386
	public class vtkContourHelper : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018C54 RID: 101460 RVA: 0x0022928E File Offset: 0x0022748E
		static vtkContourHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018C55 RID: 101461 RVA: 0x002292B6 File Offset: 0x002274B6
		public vtkContourHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018C56 RID: 101462 RVA: 0x002292C4 File Offset: 0x002274C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018C57 RID: 101463
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourHelper_Contour_01(HandleRef pThis, HandleRef cell, double value, HandleRef cellScalars, long cellId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C58 RID: 101464 RVA: 0x002292D0 File Offset: 0x002274D0
		public void Contour(vtkCell cell, double value, vtkDataArray cellScalars, long cellId)
		{
			vtkContourHelper.vtkContourHelper_Contour_01(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), cellId);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B5D RID: 7005
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B5E RID: 7006
		public new static readonly string MRClassNameKey = "class vtkContourHelper";
	}
}
