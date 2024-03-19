using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkGroupDataSetsFilter
	/// </summary>
	/// <remarks>
	///  groups inputs into a chosen composite dataset.
	///
	/// vtkGroupDataSetsFilter is a filter that can combine multiple input datasets
	/// into a vtkMultBlockDataSet, vtkPartitionedDataSet, or a
	/// vtkPartitionedDataSetCollection.
	///
	/// The inputs are added a individual blocks in the output and can be named
	/// assigned block-names using `SetInputName`.
	///
	/// This is a more generic version of `vtkMultiBlockDataGroupFilter` and should
	/// be preferred.
	/// </remarks>
	// Token: 0x020008A7 RID: 2215
	public class vtkGroupDataSetsFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016F7C RID: 94076 RVA: 0x002045E7 File Offset: 0x002027E7
		static vtkGroupDataSetsFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGroupDataSetsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGroupDataSetsFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016F7D RID: 94077 RVA: 0x0020460F File Offset: 0x0020280F
		public vtkGroupDataSetsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016F7E RID: 94078
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupDataSetsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F7F RID: 94079 RVA: 0x00204620 File Offset: 0x00202820
		public new static vtkGroupDataSetsFilter New()
		{
			vtkGroupDataSetsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupDataSetsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F80 RID: 94080 RVA: 0x00204674 File Offset: 0x00202874
		public vtkGroupDataSetsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016F81 RID: 94081 RVA: 0x002046B8 File Offset: 0x002028B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016F82 RID: 94082
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupDataSetsFilter_ClearInputNames_01(HandleRef pThis);

		/// <summary>
		/// Clears all assigned input names.
		/// </summary>
		// Token: 0x06016F83 RID: 94083 RVA: 0x002046C3 File Offset: 0x002028C3
		public void ClearInputNames()
		{
			vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_ClearInputNames_01(base.GetCppThis());
		}

		// Token: 0x06016F84 RID: 94084
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupDataSetsFilter_GetInputName_02(HandleRef pThis, int index);

		/// <summary>
		/// API to assign names for inputs. If not specified, the filter automatically
		/// creates sensible names based on the chosen output type.
		///
		/// Names are not useful or relevant if output type is
		/// `VTK_PARTITIONED_DATA_SET` and hence are ignored for that type.
		/// </summary>
		// Token: 0x06016F85 RID: 94085 RVA: 0x002046D4 File Offset: 0x002028D4
		public string GetInputName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_GetInputName_02(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016F86 RID: 94086
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F87 RID: 94087 RVA: 0x00204710 File Offset: 0x00202910
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06016F88 RID: 94088
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F89 RID: 94089 RVA: 0x00204730 File Offset: 0x00202930
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06016F8A RID: 94090
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupDataSetsFilter_GetOutputType_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the output type. Supported values are
		/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
		/// `VTK_MULTIBLOCK_DATA_SET`.
		///
		/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
		/// </summary>
		// Token: 0x06016F8B RID: 94091 RVA: 0x0020474C File Offset: 0x0020294C
		public virtual int GetOutputType()
		{
			return vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_GetOutputType_05(base.GetCppThis());
		}

		// Token: 0x06016F8C RID: 94092
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupDataSetsFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F8D RID: 94093 RVA: 0x0020476C File Offset: 0x0020296C
		public override int IsA(string type)
		{
			return vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06016F8E RID: 94094
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupDataSetsFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F8F RID: 94095 RVA: 0x0020478C File Offset: 0x0020298C
		public new static int IsTypeOf(string type)
		{
			return vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_IsTypeOf_07(type);
		}

		// Token: 0x06016F90 RID: 94096
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupDataSetsFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F91 RID: 94097 RVA: 0x002047A8 File Offset: 0x002029A8
		public new vtkGroupDataSetsFilter NewInstance()
		{
			vtkGroupDataSetsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupDataSetsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016F92 RID: 94098
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupDataSetsFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F93 RID: 94099 RVA: 0x00204804 File Offset: 0x00202A04
		public new static vtkGroupDataSetsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGroupDataSetsFilter vtkGroupDataSetsFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGroupDataSetsFilter = (vtkGroupDataSetsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGroupDataSetsFilter.Register(null);
				}
			}
			return vtkGroupDataSetsFilter;
		}

		// Token: 0x06016F94 RID: 94100
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupDataSetsFilter_SetInputName_11(HandleRef pThis, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// API to assign names for inputs. If not specified, the filter automatically
		/// creates sensible names based on the chosen output type.
		///
		/// Names are not useful or relevant if output type is
		/// `VTK_PARTITIONED_DATA_SET` and hence are ignored for that type.
		/// </summary>
		// Token: 0x06016F95 RID: 94101 RVA: 0x00204883 File Offset: 0x00202A83
		public void SetInputName(int index, string name)
		{
			vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_SetInputName_11(base.GetCppThis(), index, name);
		}

		// Token: 0x06016F96 RID: 94102
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupDataSetsFilter_SetOutputType_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the output type. Supported values are
		/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
		/// `VTK_MULTIBLOCK_DATA_SET`.
		///
		/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
		/// </summary>
		// Token: 0x06016F97 RID: 94103 RVA: 0x00204894 File Offset: 0x00202A94
		public virtual void SetOutputType(int _arg)
		{
			vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_SetOutputType_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F98 RID: 94104
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupDataSetsFilter_SetOutputTypeToMultiBlockDataSet_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the output type. Supported values are
		/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
		/// `VTK_MULTIBLOCK_DATA_SET`.
		///
		/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
		/// </summary>
		// Token: 0x06016F99 RID: 94105 RVA: 0x002048A4 File Offset: 0x00202AA4
		public void SetOutputTypeToMultiBlockDataSet()
		{
			vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_SetOutputTypeToMultiBlockDataSet_13(base.GetCppThis());
		}

		// Token: 0x06016F9A RID: 94106
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSet_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the output type. Supported values are
		/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
		/// `VTK_MULTIBLOCK_DATA_SET`.
		///
		/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
		/// </summary>
		// Token: 0x06016F9B RID: 94107 RVA: 0x002048B3 File Offset: 0x00202AB3
		public void SetOutputTypeToPartitionedDataSet()
		{
			vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSet_14(base.GetCppThis());
		}

		// Token: 0x06016F9C RID: 94108
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSetCollection_15(HandleRef pThis);

		/// <summary>
		/// Get/Set the output type. Supported values are
		/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
		/// `VTK_MULTIBLOCK_DATA_SET`.
		///
		/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
		/// </summary>
		// Token: 0x06016F9D RID: 94109 RVA: 0x002048C2 File Offset: 0x00202AC2
		public void SetOutputTypeToPartitionedDataSetCollection()
		{
			vtkGroupDataSetsFilter.vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSetCollection_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B4 RID: 6580
		public new const string MRFullTypeName = "Kitware.VTK.vtkGroupDataSetsFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B5 RID: 6581
		public new static readonly string MRClassNameKey = "class vtkGroupDataSetsFilter";
	}
}
