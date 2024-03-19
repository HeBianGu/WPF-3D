using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExplicitStructuredGridCrop
	/// </summary>
	/// <remarks>
	///    Filter which extracts a piece of explicit structured
	/// grid changing its extents.
	/// </remarks>
	// Token: 0x02000961 RID: 2401
	public class vtkExplicitStructuredGridCrop : vtkExplicitStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018FA8 RID: 102312 RVA: 0x0022D7C3 File Offset: 0x0022B9C3
		static vtkExplicitStructuredGridCrop()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExplicitStructuredGridCrop.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGridCrop"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018FA9 RID: 102313 RVA: 0x0022D7EB File Offset: 0x0022B9EB
		public vtkExplicitStructuredGridCrop(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018FAA RID: 102314
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridCrop_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FAB RID: 102315 RVA: 0x0022D7FC File Offset: 0x0022B9FC
		public new static vtkExplicitStructuredGridCrop New()
		{
			vtkExplicitStructuredGridCrop result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridCrop)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FAC RID: 102316 RVA: 0x0022D850 File Offset: 0x0022BA50
		public vtkExplicitStructuredGridCrop() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018FAD RID: 102317 RVA: 0x0022D894 File Offset: 0x0022BA94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018FAE RID: 102318
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FAF RID: 102319 RVA: 0x0022D8A0 File Offset: 0x0022BAA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018FB0 RID: 102320
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FB1 RID: 102321 RVA: 0x0022D8C0 File Offset: 0x0022BAC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018FB2 RID: 102322
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridCrop_GetOutputWholeExtent_03(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06018FB3 RID: 102323 RVA: 0x0022D8DA File Offset: 0x0022BADA
		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_GetOutputWholeExtent_03(base.GetCppThis(), extent);
		}

		// Token: 0x06018FB4 RID: 102324
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridCrop_GetOutputWholeExtent_04(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06018FB5 RID: 102325 RVA: 0x0022D8EC File Offset: 0x0022BAEC
		public IntPtr GetOutputWholeExtent()
		{
			return vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_GetOutputWholeExtent_04(base.GetCppThis());
		}

		// Token: 0x06018FB6 RID: 102326
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridCrop_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FB7 RID: 102327 RVA: 0x0022D90C File Offset: 0x0022BB0C
		public override int IsA(string type)
		{
			return vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06018FB8 RID: 102328
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridCrop_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FB9 RID: 102329 RVA: 0x0022D92C File Offset: 0x0022BB2C
		public new static int IsTypeOf(string type)
		{
			return vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_IsTypeOf_06(type);
		}

		// Token: 0x06018FBA RID: 102330
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridCrop_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FBB RID: 102331 RVA: 0x0022D948 File Offset: 0x0022BB48
		public new vtkExplicitStructuredGridCrop NewInstance()
		{
			vtkExplicitStructuredGridCrop result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridCrop)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018FBC RID: 102332
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridCrop_ResetOutputWholeExtent_09(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06018FBD RID: 102333 RVA: 0x0022D9A2 File Offset: 0x0022BBA2
		public void ResetOutputWholeExtent()
		{
			vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_ResetOutputWholeExtent_09(base.GetCppThis());
		}

		// Token: 0x06018FBE RID: 102334
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridCrop_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FBF RID: 102335 RVA: 0x0022D9B4 File Offset: 0x0022BBB4
		public new static vtkExplicitStructuredGridCrop SafeDownCast(vtkObjectBase o)
		{
			vtkExplicitStructuredGridCrop vtkExplicitStructuredGridCrop = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGridCrop = (vtkExplicitStructuredGridCrop)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGridCrop.Register(null);
				}
			}
			return vtkExplicitStructuredGridCrop;
		}

		// Token: 0x06018FC0 RID: 102336
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridCrop_SetOutputWholeExtent_11(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06018FC1 RID: 102337 RVA: 0x0022DA34 File Offset: 0x0022BC34
		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_SetOutputWholeExtent_11(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x06018FC2 RID: 102338
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridCrop_SetOutputWholeExtent_12(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06018FC3 RID: 102339 RVA: 0x0022DA64 File Offset: 0x0022BC64
		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkExplicitStructuredGridCrop.vtkExplicitStructuredGridCrop_SetOutputWholeExtent_12(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B7B RID: 7035
		public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGridCrop";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B7C RID: 7036
		public new static readonly string MRClassNameKey = "class vtkExplicitStructuredGridCrop";
	}
}
