using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeVectorComponents
	/// </summary>
	/// <remarks>
	///    merge components of many single-component arrays into one vector
	///
	/// vtkMergeVectorComponents is a filter that merges three single-component arrays
	/// into one vector. This is accomplished by creating one output vector with
	/// 3 components. The type of the output vector is vtkDoubleArray. The user
	/// needs to define the names of the single-component arrays and the attribute-type
	/// of the arrays, i.e. point-data or cell-data.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x020008BC RID: 2236
	public class vtkMergeVectorComponents : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060172D0 RID: 94928 RVA: 0x0020875B File Offset: 0x0020695B
		static vtkMergeVectorComponents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeVectorComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeVectorComponents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060172D1 RID: 94929 RVA: 0x00208783 File Offset: 0x00206983
		public vtkMergeVectorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060172D2 RID: 94930
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172D3 RID: 94931 RVA: 0x00208794 File Offset: 0x00206994
		public new static vtkMergeVectorComponents New()
		{
			vtkMergeVectorComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeVectorComponents.vtkMergeVectorComponents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeVectorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172D4 RID: 94932 RVA: 0x002087E8 File Offset: 0x002069E8
		public vtkMergeVectorComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeVectorComponents.vtkMergeVectorComponents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060172D5 RID: 94933 RVA: 0x0020882C File Offset: 0x00206A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060172D6 RID: 94934
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeVectorComponents_GetAttributeType_01(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
		/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
		/// </summary>
		// Token: 0x060172D7 RID: 94935 RVA: 0x00208838 File Offset: 0x00206A38
		public virtual int GetAttributeType()
		{
			return vtkMergeVectorComponents.vtkMergeVectorComponents_GetAttributeType_01(base.GetCppThis());
		}

		// Token: 0x060172D8 RID: 94936
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeVectorComponents_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172D9 RID: 94937 RVA: 0x00208858 File Offset: 0x00206A58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeVectorComponents.vtkMergeVectorComponents_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060172DA RID: 94938
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeVectorComponents_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172DB RID: 94939 RVA: 0x00208878 File Offset: 0x00206A78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeVectorComponents.vtkMergeVectorComponents_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060172DC RID: 94940
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_GetOutputVectorName_04(HandleRef pThis);

		/// <summary>
		/// Set the name of the output combination vector. If name is undefined, the output vector will
		/// be named, "combinationVector".
		/// </summary>
		// Token: 0x060172DD RID: 94941 RVA: 0x00208894 File Offset: 0x00206A94
		public virtual string GetOutputVectorName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeVectorComponents.vtkMergeVectorComponents_GetOutputVectorName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060172DE RID: 94942
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_GetXArrayName_05(HandleRef pThis);

		/// <summary>
		/// Set the name of the array to use as the X component of the combination vector
		/// </summary>
		// Token: 0x060172DF RID: 94943 RVA: 0x002088D0 File Offset: 0x00206AD0
		public virtual string GetXArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeVectorComponents.vtkMergeVectorComponents_GetXArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060172E0 RID: 94944
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_GetYArrayName_06(HandleRef pThis);

		/// <summary>
		/// Set the name of the array to use as the Y component of the combination vector
		/// </summary>
		// Token: 0x060172E1 RID: 94945 RVA: 0x0020890C File Offset: 0x00206B0C
		public virtual string GetYArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeVectorComponents.vtkMergeVectorComponents_GetYArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060172E2 RID: 94946
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_GetZArrayName_07(HandleRef pThis);

		/// <summary>
		/// Set the name of the array to use as the Z attribute of the combination vector
		/// </summary>
		// Token: 0x060172E3 RID: 94947 RVA: 0x00208948 File Offset: 0x00206B48
		public virtual string GetZArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeVectorComponents.vtkMergeVectorComponents_GetZArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060172E4 RID: 94948
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeVectorComponents_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172E5 RID: 94949 RVA: 0x00208984 File Offset: 0x00206B84
		public override int IsA(string type)
		{
			return vtkMergeVectorComponents.vtkMergeVectorComponents_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060172E6 RID: 94950
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeVectorComponents_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172E7 RID: 94951 RVA: 0x002089A4 File Offset: 0x00206BA4
		public new static int IsTypeOf(string type)
		{
			return vtkMergeVectorComponents.vtkMergeVectorComponents_IsTypeOf_09(type);
		}

		// Token: 0x060172E8 RID: 94952
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172E9 RID: 94953 RVA: 0x002089C0 File Offset: 0x00206BC0
		public new vtkMergeVectorComponents NewInstance()
		{
			vtkMergeVectorComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeVectorComponents.vtkMergeVectorComponents_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeVectorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060172EA RID: 94954
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeVectorComponents_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060172EB RID: 94955 RVA: 0x00208A1C File Offset: 0x00206C1C
		public new static vtkMergeVectorComponents SafeDownCast(vtkObjectBase o)
		{
			vtkMergeVectorComponents vtkMergeVectorComponents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeVectorComponents.vtkMergeVectorComponents_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeVectorComponents = (vtkMergeVectorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeVectorComponents.Register(null);
				}
			}
			return vtkMergeVectorComponents;
		}

		// Token: 0x060172EC RID: 94956
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetAttributeType_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
		/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
		/// </summary>
		// Token: 0x060172ED RID: 94957 RVA: 0x00208A9B File Offset: 0x00206C9B
		public virtual void SetAttributeType(int _arg)
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetAttributeType_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060172EE RID: 94958
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetAttributeTypeToCellData_14(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
		/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
		/// </summary>
		// Token: 0x060172EF RID: 94959 RVA: 0x00208AAB File Offset: 0x00206CAB
		public void SetAttributeTypeToCellData()
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetAttributeTypeToCellData_14(base.GetCppThis());
		}

		// Token: 0x060172F0 RID: 94960
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetAttributeTypeToPointData_15(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets). The default value is vtkDataObject::POINT. The input value for
		/// this function should be either vtkDataObject::POINT or vtkDataObject::CELL.
		/// </summary>
		// Token: 0x060172F1 RID: 94961 RVA: 0x00208ABA File Offset: 0x00206CBA
		public void SetAttributeTypeToPointData()
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetAttributeTypeToPointData_15(base.GetCppThis());
		}

		// Token: 0x060172F2 RID: 94962
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetOutputVectorName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the output combination vector. If name is undefined, the output vector will
		/// be named, "combinationVector".
		/// </summary>
		// Token: 0x060172F3 RID: 94963 RVA: 0x00208AC9 File Offset: 0x00206CC9
		public virtual void SetOutputVectorName(string _arg)
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetOutputVectorName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060172F4 RID: 94964
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetXArrayName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the array to use as the X component of the combination vector
		/// </summary>
		// Token: 0x060172F5 RID: 94965 RVA: 0x00208AD9 File Offset: 0x00206CD9
		public virtual void SetXArrayName(string _arg)
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetXArrayName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060172F6 RID: 94966
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetYArrayName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the array to use as the Y component of the combination vector
		/// </summary>
		// Token: 0x060172F7 RID: 94967 RVA: 0x00208AE9 File Offset: 0x00206CE9
		public virtual void SetYArrayName(string _arg)
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetYArrayName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060172F8 RID: 94968
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeVectorComponents_SetZArrayName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the array to use as the Z attribute of the combination vector
		/// </summary>
		// Token: 0x060172F9 RID: 94969 RVA: 0x00208AF9 File Offset: 0x00206CF9
		public virtual void SetZArrayName(string _arg)
		{
			vtkMergeVectorComponents.vtkMergeVectorComponents_SetZArrayName_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E6 RID: 6630
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeVectorComponents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E7 RID: 6631
		public new static readonly string MRClassNameKey = "class vtkMergeVectorComponents";
	}
}
