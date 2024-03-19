using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPPolyDataNormals
	/// </summary>
	/// <remarks>
	///    compute normals for polygonal mesh
	///
	/// </remarks>
	// Token: 0x02000525 RID: 1317
	public class vtkPPolyDataNormals : vtkPolyDataNormals
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EB91 RID: 60305 RVA: 0x00148715 File Offset: 0x00146915
		static vtkPPolyDataNormals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPPolyDataNormals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPPolyDataNormals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB92 RID: 60306 RVA: 0x0014873D File Offset: 0x0014693D
		public vtkPPolyDataNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EB93 RID: 60307
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPolyDataNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB94 RID: 60308 RVA: 0x0014874C File Offset: 0x0014694C
		public new static vtkPPolyDataNormals New()
		{
			vtkPPolyDataNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPolyDataNormals.vtkPPolyDataNormals_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPolyDataNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB95 RID: 60309 RVA: 0x001487A0 File Offset: 0x001469A0
		public vtkPPolyDataNormals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPPolyDataNormals.vtkPPolyDataNormals_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB96 RID: 60310 RVA: 0x001487E4 File Offset: 0x001469E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EB97 RID: 60311
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPPolyDataNormals_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB98 RID: 60312 RVA: 0x001487F0 File Offset: 0x001469F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EB99 RID: 60313
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPPolyDataNormals_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB9A RID: 60314 RVA: 0x00148810 File Offset: 0x00146A10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EB9B RID: 60315
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPPolyDataNormals_GetPieceInvariant_03(HandleRef pThis);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600EB9C RID: 60316 RVA: 0x0014882C File Offset: 0x00146A2C
		public virtual int GetPieceInvariant()
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_GetPieceInvariant_03(base.GetCppThis());
		}

		// Token: 0x0600EB9D RID: 60317
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPPolyDataNormals_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB9E RID: 60318 RVA: 0x0014884C File Offset: 0x00146A4C
		public override int IsA(string type)
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EB9F RID: 60319
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPPolyDataNormals_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBA0 RID: 60320 RVA: 0x0014886C File Offset: 0x00146A6C
		public new static int IsTypeOf(string type)
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_IsTypeOf_05(type);
		}

		// Token: 0x0600EBA1 RID: 60321
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPolyDataNormals_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBA2 RID: 60322 RVA: 0x00148888 File Offset: 0x00146A88
		public new vtkPPolyDataNormals NewInstance()
		{
			vtkPPolyDataNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPolyDataNormals.vtkPPolyDataNormals_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPolyDataNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EBA3 RID: 60323
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPPolyDataNormals_PieceInvariantOff_08(HandleRef pThis);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600EBA4 RID: 60324 RVA: 0x001488E2 File Offset: 0x00146AE2
		public virtual void PieceInvariantOff()
		{
			vtkPPolyDataNormals.vtkPPolyDataNormals_PieceInvariantOff_08(base.GetCppThis());
		}

		// Token: 0x0600EBA5 RID: 60325
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPPolyDataNormals_PieceInvariantOn_09(HandleRef pThis);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600EBA6 RID: 60326 RVA: 0x001488F1 File Offset: 0x00146AF1
		public virtual void PieceInvariantOn()
		{
			vtkPPolyDataNormals.vtkPPolyDataNormals_PieceInvariantOn_09(base.GetCppThis());
		}

		// Token: 0x0600EBA7 RID: 60327
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPolyDataNormals_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EBA8 RID: 60328 RVA: 0x00148900 File Offset: 0x00146B00
		public new static vtkPPolyDataNormals SafeDownCast(vtkObjectBase o)
		{
			vtkPPolyDataNormals vtkPPolyDataNormals = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPolyDataNormals.vtkPPolyDataNormals_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPPolyDataNormals = (vtkPPolyDataNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPPolyDataNormals.Register(null);
				}
			}
			return vtkPPolyDataNormals;
		}

		// Token: 0x0600EBA9 RID: 60329
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPPolyDataNormals_SetPieceInvariant_11(HandleRef pThis, int _arg);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600EBAA RID: 60330 RVA: 0x0014897F File Offset: 0x00146B7F
		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPPolyDataNormals.vtkPPolyDataNormals_SetPieceInvariant_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001139 RID: 4409
		public new const string MRFullTypeName = "Kitware.VTK.vtkPPolyDataNormals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400113A RID: 4410
		public new static readonly string MRClassNameKey = "class vtkPPolyDataNormals";
	}
}
