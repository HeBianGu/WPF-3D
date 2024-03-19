using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageVariance3D
	/// </summary>
	/// <remarks>
	///    Variance in a neighborhood.
	///
	/// vtkImageVariance3D replaces each pixel with a measurement of
	/// pixel variance in a elliptical neighborhood centered on that pixel.
	/// The value computed is not exactly the variance.
	/// The difference between the neighbor values and center value is computed
	/// and squared for each neighbor.  These values are summed and divided by
	/// the total number of neighbors to produce the output value.
	/// </remarks>
	// Token: 0x02000493 RID: 1171
	public class vtkImageVariance3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D779 RID: 55161 RVA: 0x0012B8FF File Offset: 0x00129AFF
		static vtkImageVariance3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageVariance3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageVariance3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D77A RID: 55162 RVA: 0x0012B927 File Offset: 0x00129B27
		public vtkImageVariance3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D77B RID: 55163
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageVariance3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D77C RID: 55164 RVA: 0x0012B938 File Offset: 0x00129B38
		public new static vtkImageVariance3D New()
		{
			vtkImageVariance3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageVariance3D.vtkImageVariance3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageVariance3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D77D RID: 55165 RVA: 0x0012B98C File Offset: 0x00129B8C
		public vtkImageVariance3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageVariance3D.vtkImageVariance3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D77E RID: 55166 RVA: 0x0012B9D0 File Offset: 0x00129BD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D77F RID: 55167
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageVariance3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D780 RID: 55168 RVA: 0x0012B9DC File Offset: 0x00129BDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageVariance3D.vtkImageVariance3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D781 RID: 55169
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageVariance3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D782 RID: 55170 RVA: 0x0012B9FC File Offset: 0x00129BFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageVariance3D.vtkImageVariance3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D783 RID: 55171
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageVariance3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D784 RID: 55172 RVA: 0x0012BA18 File Offset: 0x00129C18
		public override int IsA(string type)
		{
			return vtkImageVariance3D.vtkImageVariance3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D785 RID: 55173
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageVariance3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D786 RID: 55174 RVA: 0x0012BA38 File Offset: 0x00129C38
		public new static int IsTypeOf(string type)
		{
			return vtkImageVariance3D.vtkImageVariance3D_IsTypeOf_04(type);
		}

		// Token: 0x0600D787 RID: 55175
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageVariance3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D788 RID: 55176 RVA: 0x0012BA54 File Offset: 0x00129C54
		public new vtkImageVariance3D NewInstance()
		{
			vtkImageVariance3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageVariance3D.vtkImageVariance3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageVariance3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D789 RID: 55177
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageVariance3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D78A RID: 55178 RVA: 0x0012BAB0 File Offset: 0x00129CB0
		public new static vtkImageVariance3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageVariance3D vtkImageVariance3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageVariance3D.vtkImageVariance3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageVariance3D = (vtkImageVariance3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageVariance3D.Register(null);
				}
			}
			return vtkImageVariance3D;
		}

		// Token: 0x0600D78B RID: 55179
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageVariance3D_SetKernelSize_08(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// This method sets the size of the neighborhood.  It also sets the default
		/// middle of the neighborhood and computes the Elliptical foot print.
		/// </summary>
		// Token: 0x0600D78C RID: 55180 RVA: 0x0012BB2F File Offset: 0x00129D2F
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageVariance3D.vtkImageVariance3D_SetKernelSize_08(base.GetCppThis(), size0, size1, size2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FCE RID: 4046
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageVariance3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FCF RID: 4047
		public new static readonly string MRClassNameKey = "class vtkImageVariance3D";
	}
}
