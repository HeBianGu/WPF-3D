using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkGroupTimeStepsFilter
	/// </summary>
	/// <remarks>
	///  converts a temporal dataset into non-temporal dataset.
	///
	/// vtkGroupTimeStepsFilter is intended to convert a temporal input with
	/// multiple timesteps into a single dataset will all timesteps available.
	/// The filter requests all timesteps from the upstream one after another and
	/// then packages it into a single output vtkPartitionedDataSetCollection
	/// or vtkMultiBlockDataSet based on the input data type.
	/// In most cases vtkPartitionedDataSetCollection is produced. Only when
	/// the input cannot be stored in a vtkPartitionedDataSetCollection,
	/// vtkMultiBlockDataSet is created instead.
	///
	/// @section vtkGroupTimeStepsFilter-Limitations Limitations
	///
	/// The filter may not work correctly if the input dataset type changes over
	/// time.
	/// </remarks>
	// Token: 0x020008A8 RID: 2216
	public class vtkGroupTimeStepsFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016F9E RID: 94110 RVA: 0x002048D1 File Offset: 0x00202AD1
		static vtkGroupTimeStepsFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGroupTimeStepsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGroupTimeStepsFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016F9F RID: 94111 RVA: 0x002048F9 File Offset: 0x00202AF9
		public vtkGroupTimeStepsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016FA0 RID: 94112
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupTimeStepsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FA1 RID: 94113 RVA: 0x00204908 File Offset: 0x00202B08
		public new static vtkGroupTimeStepsFilter New()
		{
			vtkGroupTimeStepsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupTimeStepsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FA2 RID: 94114 RVA: 0x0020495C File Offset: 0x00202B5C
		public vtkGroupTimeStepsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016FA3 RID: 94115 RVA: 0x002049A0 File Offset: 0x00202BA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016FA4 RID: 94116
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGroupTimeStepsFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FA5 RID: 94117 RVA: 0x002049AC File Offset: 0x00202BAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016FA6 RID: 94118
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGroupTimeStepsFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FA7 RID: 94119 RVA: 0x002049CC File Offset: 0x00202BCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016FA8 RID: 94120
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupTimeStepsFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FA9 RID: 94121 RVA: 0x002049E8 File Offset: 0x00202BE8
		public override int IsA(string type)
		{
			return vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016FAA RID: 94122
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupTimeStepsFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FAB RID: 94123 RVA: 0x00204A08 File Offset: 0x00202C08
		public new static int IsTypeOf(string type)
		{
			return vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_IsTypeOf_04(type);
		}

		// Token: 0x06016FAC RID: 94124
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupTimeStepsFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FAD RID: 94125 RVA: 0x00204A24 File Offset: 0x00202C24
		public new vtkGroupTimeStepsFilter NewInstance()
		{
			vtkGroupTimeStepsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupTimeStepsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016FAE RID: 94126
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupTimeStepsFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FAF RID: 94127 RVA: 0x00204A80 File Offset: 0x00202C80
		public new static vtkGroupTimeStepsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGroupTimeStepsFilter vtkGroupTimeStepsFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupTimeStepsFilter.vtkGroupTimeStepsFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGroupTimeStepsFilter = (vtkGroupTimeStepsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGroupTimeStepsFilter.Register(null);
				}
			}
			return vtkGroupTimeStepsFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B6 RID: 6582
		public new const string MRFullTypeName = "Kitware.VTK.vtkGroupTimeStepsFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B7 RID: 6583
		public new static readonly string MRClassNameKey = "class vtkGroupTimeStepsFilter";
	}
}
