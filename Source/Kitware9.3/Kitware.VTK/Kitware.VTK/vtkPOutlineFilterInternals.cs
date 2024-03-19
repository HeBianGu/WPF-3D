using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPOutlineFilterInternals
	/// </summary>
	/// <remarks>
	///    create wireframe outline (or corners) for arbitrary data set
	///
	/// vtkPOutlineFilterInternals has common code for vtkOutlineFilter and
	/// vtkOutlineCornerFilter. It assumes the filter is operated in a data parallel
	/// pipeline.
	///
	/// This class does not inherit from vtkObject and is not intended to be used
	/// outside of VTK.
	/// </remarks>
	// Token: 0x02000523 RID: 1315
	public class vtkPOutlineFilterInternals : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EB2E RID: 60206 RVA: 0x0014814B File Offset: 0x0014634B
		static vtkPOutlineFilterInternals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOutlineFilterInternals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOutlineFilterInternals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB2F RID: 60207 RVA: 0x00148173 File Offset: 0x00146373
		public vtkPOutlineFilterInternals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB30 RID: 60208 RVA: 0x00148181 File Offset: 0x00146381
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EB31 RID: 60209
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOutlineFilterInternals_SetController_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the controller to be used.
		/// Default is nullptr.
		/// </summary>
		// Token: 0x0600EB32 RID: 60210 RVA: 0x0014818C File Offset: 0x0014638C
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkPOutlineFilterInternals.vtkPOutlineFilterInternals_SetController_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EB33 RID: 60211
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOutlineFilterInternals_SetCornerFactor_02(HandleRef pThis, double cornerFactor);

		/// <summary>
		/// Set the corner factor to use when creating corner outline.
		/// Default is 0.2.
		/// </summary>
		// Token: 0x0600EB34 RID: 60212 RVA: 0x001481BB File Offset: 0x001463BB
		public void SetCornerFactor(double cornerFactor)
		{
			vtkPOutlineFilterInternals.vtkPOutlineFilterInternals_SetCornerFactor_02(base.GetCppThis(), cornerFactor);
		}

		// Token: 0x0600EB35 RID: 60213
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOutlineFilterInternals_SetIsCornerSource_03(HandleRef pThis, byte value);

		/// <summary>
		/// Set whether or not to generate a corner outline.
		/// Default is false.
		/// </summary>
		// Token: 0x0600EB36 RID: 60214 RVA: 0x001481CB File Offset: 0x001463CB
		public void SetIsCornerSource(bool value)
		{
			vtkPOutlineFilterInternals.vtkPOutlineFilterInternals_SetIsCornerSource_03(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001135 RID: 4405
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOutlineFilterInternals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001136 RID: 4406
		public new static readonly string MRClassNameKey = "class vtkPOutlineFilterInternals";
	}
}
