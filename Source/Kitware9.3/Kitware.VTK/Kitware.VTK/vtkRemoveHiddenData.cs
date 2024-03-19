using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRemoveHiddenData
	/// </summary>
	/// <remarks>
	///    Removes the rows/edges/vertices of
	/// input data flagged by ann.
	///
	///
	/// Output only those rows/vertices/edges of the input vtkDataObject that
	/// are visible, as defined by the vtkAnnotation::HIDE() flag of the input
	/// vtkAnnotationLayers.
	/// Inputs:
	///    Port 0 - vtkDataObject
	///    Port 1 - vtkAnnotationLayers (optional)
	///
	/// </remarks>
	// Token: 0x0200068E RID: 1678
	public class vtkRemoveHiddenData : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012019 RID: 73753 RVA: 0x0019346C File Offset: 0x0019166C
		static vtkRemoveHiddenData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveHiddenData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveHiddenData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601201A RID: 73754 RVA: 0x00193494 File Offset: 0x00191694
		public vtkRemoveHiddenData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601201B RID: 73755
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveHiddenData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601201C RID: 73756 RVA: 0x001934A4 File Offset: 0x001916A4
		public new static vtkRemoveHiddenData New()
		{
			vtkRemoveHiddenData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveHiddenData.vtkRemoveHiddenData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveHiddenData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601201D RID: 73757 RVA: 0x001934F8 File Offset: 0x001916F8
		public vtkRemoveHiddenData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRemoveHiddenData.vtkRemoveHiddenData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601201E RID: 73758 RVA: 0x0019353C File Offset: 0x0019173C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601201F RID: 73759
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveHiddenData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012020 RID: 73760 RVA: 0x00193548 File Offset: 0x00191748
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRemoveHiddenData.vtkRemoveHiddenData_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012021 RID: 73761
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveHiddenData_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012022 RID: 73762 RVA: 0x00193568 File Offset: 0x00191768
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRemoveHiddenData.vtkRemoveHiddenData_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012023 RID: 73763
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveHiddenData_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012024 RID: 73764 RVA: 0x00193584 File Offset: 0x00191784
		public override int IsA(string type)
		{
			return vtkRemoveHiddenData.vtkRemoveHiddenData_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012025 RID: 73765
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveHiddenData_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012026 RID: 73766 RVA: 0x001935A4 File Offset: 0x001917A4
		public new static int IsTypeOf(string type)
		{
			return vtkRemoveHiddenData.vtkRemoveHiddenData_IsTypeOf_04(type);
		}

		// Token: 0x06012027 RID: 73767
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveHiddenData_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012028 RID: 73768 RVA: 0x001935C0 File Offset: 0x001917C0
		public new vtkRemoveHiddenData NewInstance()
		{
			vtkRemoveHiddenData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveHiddenData.vtkRemoveHiddenData_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveHiddenData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012029 RID: 73769
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveHiddenData_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601202A RID: 73770 RVA: 0x0019361C File Offset: 0x0019181C
		public new static vtkRemoveHiddenData SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveHiddenData vtkRemoveHiddenData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveHiddenData.vtkRemoveHiddenData_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveHiddenData = (vtkRemoveHiddenData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveHiddenData.Register(null);
				}
			}
			return vtkRemoveHiddenData;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014C7 RID: 5319
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveHiddenData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014C8 RID: 5320
		public new static readonly string MRClassNameKey = "class vtkRemoveHiddenData";
	}
}
