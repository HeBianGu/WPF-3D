using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointData
	/// </summary>
	/// <remarks>
	///    represent and manipulate point attribute data
	///
	/// vtkPointData is a class that is used to represent and manipulate
	/// point attribute data (e.g., scalars, vectors, normals, texture
	/// coordinates, etc.) Most of the functionality is handled by
	/// vtkDataSetAttributes.
	///
	/// By default, `GhostTypesToSkip` is set to `DUPLICATEPOINT | HIDDENPOINT`.
	/// See `vtkDataSetAttributes` for the definition of those constants.
	/// </remarks>
	// Token: 0x02000A9B RID: 2715
	public class vtkPointData : vtkDataSetAttributes
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C7AF RID: 116655 RVA: 0x00280164 File Offset: 0x0027E364
		static vtkPointData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C7B0 RID: 116656 RVA: 0x0028018C File Offset: 0x0027E38C
		public vtkPointData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C7B1 RID: 116657
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7B2 RID: 116658 RVA: 0x0028019C File Offset: 0x0027E39C
		public new static vtkPointData New()
		{
			vtkPointData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointData.vtkPointData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7B3 RID: 116659 RVA: 0x002801F0 File Offset: 0x0027E3F0
		public vtkPointData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointData.vtkPointData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C7B4 RID: 116660 RVA: 0x00280234 File Offset: 0x0027E434
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C7B5 RID: 116661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointData_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7B6 RID: 116662 RVA: 0x00280240 File Offset: 0x0027E440
		public new static vtkPointData ExtendedNew()
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointData.vtkPointData_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		// Token: 0x0601C7B7 RID: 116663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7B8 RID: 116664 RVA: 0x002802AC File Offset: 0x0027E4AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointData.vtkPointData_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601C7B9 RID: 116665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointData_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7BA RID: 116666 RVA: 0x002802CC File Offset: 0x0027E4CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointData.vtkPointData_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601C7BB RID: 116667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointData_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7BC RID: 116668 RVA: 0x002802E8 File Offset: 0x0027E4E8
		public override int IsA(string type)
		{
			return vtkPointData.vtkPointData_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C7BD RID: 116669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointData_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7BE RID: 116670 RVA: 0x00280308 File Offset: 0x0027E508
		public new static int IsTypeOf(string type)
		{
			return vtkPointData.vtkPointData_IsTypeOf_05(type);
		}

		// Token: 0x0601C7BF RID: 116671
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointData_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7C0 RID: 116672 RVA: 0x00280324 File Offset: 0x0027E524
		public new vtkPointData NewInstance()
		{
			vtkPointData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointData.vtkPointData_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C7C1 RID: 116673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7C2 RID: 116674 RVA: 0x00280380 File Offset: 0x0027E580
		public new static vtkPointData SafeDownCast(vtkObjectBase o)
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointData.vtkPointData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E37 RID: 7735
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E38 RID: 7736
		public new static readonly string MRClassNameKey = "class vtkPointData";
	}
}
