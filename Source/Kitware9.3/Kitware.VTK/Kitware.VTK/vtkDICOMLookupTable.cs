using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMLookupTable
	/// \brief Lookup tables from DICOM data.
	///
	/// This class can create VTK lookup tables from the information in a
	/// DICOM data set.  Lookup tables can be created from a palette LUT,
	/// or from standard DICOM LUTs such as HOT_IRON.
	/// </summary>
	// Token: 0x0200003F RID: 63
	public class vtkDICOMLookupTable : vtkLookupTable
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000B96 RID: 2966 RVA: 0x00017689 File Offset: 0x00015889
		static vtkDICOMLookupTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMLookupTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000B97 RID: 2967 RVA: 0x000176B1 File Offset: 0x000158B1
		public vtkDICOMLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000B98 RID: 2968
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000B99 RID: 2969 RVA: 0x000176C0 File Offset: 0x000158C0
		public new static vtkDICOMLookupTable New()
		{
			vtkDICOMLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMLookupTable.vtkDICOMLookupTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000B9A RID: 2970 RVA: 0x00017714 File Offset: 0x00015914
		public vtkDICOMLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMLookupTable.vtkDICOMLookupTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000B9B RID: 2971 RVA: 0x00017758 File Offset: 0x00015958
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000B9C RID: 2972
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMLookupTable_BuildImagePalette_01(HandleRef pThis, HandleRef meta, int idx);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000B9D RID: 2973 RVA: 0x00017764 File Offset: 0x00015964
		public void BuildImagePalette(vtkDICOMMetaData meta, int idx)
		{
			vtkDICOMLookupTable.vtkDICOMLookupTable_BuildImagePalette_01(base.GetCppThis(), (meta == null) ? default(HandleRef) : meta.GetCppThis(), idx);
		}

		// Token: 0x06000B9E RID: 2974
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMLookupTable_BuildStandardPalette_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000B9F RID: 2975 RVA: 0x00017794 File Offset: 0x00015994
		public void BuildStandardPalette(string name)
		{
			vtkDICOMLookupTable.vtkDICOMLookupTable_BuildStandardPalette_02(base.GetCppThis(), name);
		}

		// Token: 0x06000BA0 RID: 2976
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMLookupTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BA1 RID: 2977 RVA: 0x000177A4 File Offset: 0x000159A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMLookupTable.vtkDICOMLookupTable_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06000BA2 RID: 2978
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMLookupTable_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BA3 RID: 2979 RVA: 0x000177C4 File Offset: 0x000159C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMLookupTable.vtkDICOMLookupTable_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06000BA4 RID: 2980
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMLookupTable_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BA5 RID: 2981 RVA: 0x000177E0 File Offset: 0x000159E0
		public override int IsA(string type)
		{
			return vtkDICOMLookupTable.vtkDICOMLookupTable_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06000BA6 RID: 2982
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMLookupTable_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BA7 RID: 2983 RVA: 0x00017800 File Offset: 0x00015A00
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMLookupTable.vtkDICOMLookupTable_IsTypeOf_06(type);
		}

		// Token: 0x06000BA8 RID: 2984
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMLookupTable_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001781C File Offset: 0x00015A1C
		public new vtkDICOMLookupTable NewInstance()
		{
			vtkDICOMLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMLookupTable.vtkDICOMLookupTable_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000BAA RID: 2986
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMLookupTable_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BAB RID: 2987 RVA: 0x00017878 File Offset: 0x00015A78
		public new static vtkDICOMLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMLookupTable vtkDICOMLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMLookupTable.vtkDICOMLookupTable_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMLookupTable = (vtkDICOMLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMLookupTable.Register(null);
				}
			}
			return vtkDICOMLookupTable;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003AF RID: 943
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMLookupTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B0 RID: 944
		public new static readonly string MRClassNameKey = "class vtkDICOMLookupTable";
	}
}
