using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyLineSource
	/// </summary>
	/// <remarks>
	///    create a poly line from a list of input points
	///
	/// vtkPolyLineSource is a source object that creates a poly line from
	/// user-specified points. The output is a vtkPolyLine.
	/// </remarks>
	// Token: 0x0200083A RID: 2106
	public class vtkPolyLineSource : vtkPolyPointSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015CB4 RID: 89268 RVA: 0x001EBF6F File Offset: 0x001EA16F
		static vtkPolyLineSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyLineSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyLineSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015CB5 RID: 89269 RVA: 0x001EBF97 File Offset: 0x001EA197
		public vtkPolyLineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015CB6 RID: 89270
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CB7 RID: 89271 RVA: 0x001EBFA8 File Offset: 0x001EA1A8
		public new static vtkPolyLineSource New()
		{
			vtkPolyLineSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineSource.vtkPolyLineSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CB8 RID: 89272 RVA: 0x001EBFFC File Offset: 0x001EA1FC
		public vtkPolyLineSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyLineSource.vtkPolyLineSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015CB9 RID: 89273 RVA: 0x001EC040 File Offset: 0x001EA240
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015CBA RID: 89274
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineSource_ClosedOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to close the poly line by connecting the last and first points.
		/// </summary>
		// Token: 0x06015CBB RID: 89275 RVA: 0x001EC04B File Offset: 0x001EA24B
		public virtual void ClosedOff()
		{
			vtkPolyLineSource.vtkPolyLineSource_ClosedOff_01(base.GetCppThis());
		}

		// Token: 0x06015CBC RID: 89276
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineSource_ClosedOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to close the poly line by connecting the last and first points.
		/// </summary>
		// Token: 0x06015CBD RID: 89277 RVA: 0x001EC05A File Offset: 0x001EA25A
		public virtual void ClosedOn()
		{
			vtkPolyLineSource.vtkPolyLineSource_ClosedOn_02(base.GetCppThis());
		}

		// Token: 0x06015CBE RID: 89278
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineSource_GetClosed_03(HandleRef pThis);

		/// <summary>
		/// Set whether to close the poly line by connecting the last and first points.
		/// </summary>
		// Token: 0x06015CBF RID: 89279 RVA: 0x001EC06C File Offset: 0x001EA26C
		public virtual int GetClosed()
		{
			return vtkPolyLineSource.vtkPolyLineSource_GetClosed_03(base.GetCppThis());
		}

		// Token: 0x06015CC0 RID: 89280
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLineSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CC1 RID: 89281 RVA: 0x001EC08C File Offset: 0x001EA28C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyLineSource.vtkPolyLineSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06015CC2 RID: 89282
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLineSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CC3 RID: 89283 RVA: 0x001EC0AC File Offset: 0x001EA2AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyLineSource.vtkPolyLineSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06015CC4 RID: 89284
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineSource_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CC5 RID: 89285 RVA: 0x001EC0C8 File Offset: 0x001EA2C8
		public override int IsA(string type)
		{
			return vtkPolyLineSource.vtkPolyLineSource_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06015CC6 RID: 89286
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineSource_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CC7 RID: 89287 RVA: 0x001EC0E8 File Offset: 0x001EA2E8
		public new static int IsTypeOf(string type)
		{
			return vtkPolyLineSource.vtkPolyLineSource_IsTypeOf_07(type);
		}

		// Token: 0x06015CC8 RID: 89288
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CC9 RID: 89289 RVA: 0x001EC104 File Offset: 0x001EA304
		public new vtkPolyLineSource NewInstance()
		{
			vtkPolyLineSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineSource.vtkPolyLineSource_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015CCA RID: 89290
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CCB RID: 89291 RVA: 0x001EC160 File Offset: 0x001EA360
		public new static vtkPolyLineSource SafeDownCast(vtkObjectBase o)
		{
			vtkPolyLineSource vtkPolyLineSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineSource.vtkPolyLineSource_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyLineSource = (vtkPolyLineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyLineSource.Register(null);
				}
			}
			return vtkPolyLineSource;
		}

		// Token: 0x06015CCC RID: 89292
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineSource_SetClosed_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to close the poly line by connecting the last and first points.
		/// </summary>
		// Token: 0x06015CCD RID: 89293 RVA: 0x001EC1DF File Offset: 0x001EA3DF
		public virtual void SetClosed(int _arg)
		{
			vtkPolyLineSource.vtkPolyLineSource_SetClosed_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018CB RID: 6347
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyLineSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018CC RID: 6348
		public new static readonly string MRClassNameKey = "class vtkPolyLineSource";
	}
}
