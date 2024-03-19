using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellData
	/// </summary>
	/// <remarks>
	///    represent and manipulate cell attribute data
	///
	/// vtkCellData is a class that is used to represent and manipulate
	/// cell attribute data (e.g., scalars, vectors, normals, texture
	/// coordinates, etc.) Special methods are provided to work with filter
	/// objects, such as passing data through filter, copying data from one
	/// cell to another, and interpolating data given cell interpolation weights.
	///
	/// By default, `GhostTypesToSkip` is set to `DUPLICATECELL | HIDDENCELL | REFINEDCELL`.
	/// See `vtkDataSetAttributes` for the definition of those constants.
	/// </remarks>
	// Token: 0x02000A1D RID: 2589
	public class vtkCellData : vtkDataSetAttributes
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AFE6 RID: 110566 RVA: 0x0025A38E File Offset: 0x0025858E
		static vtkCellData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AFE7 RID: 110567 RVA: 0x0025A3B6 File Offset: 0x002585B6
		public vtkCellData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AFE8 RID: 110568
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFE9 RID: 110569 RVA: 0x0025A3C4 File Offset: 0x002585C4
		public new static vtkCellData New()
		{
			vtkCellData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellData.vtkCellData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFEA RID: 110570 RVA: 0x0025A418 File Offset: 0x00258618
		public vtkCellData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellData.vtkCellData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AFEB RID: 110571 RVA: 0x0025A45C File Offset: 0x0025865C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AFEC RID: 110572
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellData_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFED RID: 110573 RVA: 0x0025A468 File Offset: 0x00258668
		public new static vtkCellData ExtendedNew()
		{
			vtkCellData vtkCellData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellData.vtkCellData_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellData = (vtkCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellData.Register(null);
				}
			}
			return vtkCellData;
		}

		// Token: 0x0601AFEE RID: 110574
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFEF RID: 110575 RVA: 0x0025A4D4 File Offset: 0x002586D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellData.vtkCellData_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601AFF0 RID: 110576
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellData_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFF1 RID: 110577 RVA: 0x0025A4F4 File Offset: 0x002586F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellData.vtkCellData_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601AFF2 RID: 110578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellData_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFF3 RID: 110579 RVA: 0x0025A510 File Offset: 0x00258710
		public override int IsA(string type)
		{
			return vtkCellData.vtkCellData_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601AFF4 RID: 110580
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellData_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFF5 RID: 110581 RVA: 0x0025A530 File Offset: 0x00258730
		public new static int IsTypeOf(string type)
		{
			return vtkCellData.vtkCellData_IsTypeOf_05(type);
		}

		// Token: 0x0601AFF6 RID: 110582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellData_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFF7 RID: 110583 RVA: 0x0025A54C File Offset: 0x0025874C
		public new vtkCellData NewInstance()
		{
			vtkCellData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellData.vtkCellData_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AFF8 RID: 110584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AFF9 RID: 110585 RVA: 0x0025A5A8 File Offset: 0x002587A8
		public new static vtkCellData SafeDownCast(vtkObjectBase o)
		{
			vtkCellData vtkCellData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellData.vtkCellData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellData = (vtkCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellData.Register(null);
				}
			}
			return vtkCellData;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D29 RID: 7465
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D2A RID: 7466
		public new static readonly string MRClassNameKey = "class vtkCellData";
	}
}
