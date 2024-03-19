using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataProbeFilter
	/// </summary>
	/// <remarks>
	///    subclass of vtkProbeFilter which supports
	/// composite datasets in the input.
	///
	/// vtkCompositeDataProbeFilter supports probing into multi-group datasets.
	/// It sequentially probes through each concrete dataset within the composite
	/// probing at only those locations at which there were no hits when probing
	/// earlier datasets. For Hierarchical datasets, this traversal through leaf
	/// datasets is done in reverse order of levels i.e. highest level first.
	/// To keep the ability of using locators with a composite input, we use a map that
	/// maps a dataset belonging to the composite input to its FindCell strategy.
	///
	/// When dealing with composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in all
	/// the blocks i.e. partial array are removed.
	/// When PassPartialArrays is turned on, this behavior is changed to take a
	/// union of all arrays present thus partial arrays are passed as well. However,
	/// for composite dataset input, this filter still produces a non-composite
	/// output. For all those locations in a block of where a particular data array
	/// is missing, this filter uses vtkMath::Nan() for double and float arrays,
	/// while 0 for all other types of arrays i.e int, char etc.
	/// </remarks>
	// Token: 0x02000527 RID: 1319
	public class vtkCompositeDataProbeFilter : vtkProbeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EC0D RID: 60429 RVA: 0x001490FB File Offset: 0x001472FB
		static vtkCompositeDataProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC0E RID: 60430 RVA: 0x00149123 File Offset: 0x00147323
		public vtkCompositeDataProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EC0F RID: 60431
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC10 RID: 60432 RVA: 0x00149134 File Offset: 0x00147334
		public new static vtkCompositeDataProbeFilter New()
		{
			vtkCompositeDataProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC11 RID: 60433 RVA: 0x00149188 File Offset: 0x00147388
		public vtkCompositeDataProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC12 RID: 60434 RVA: 0x001491CC File Offset: 0x001473CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EC13 RID: 60435
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC14 RID: 60436 RVA: 0x001491D8 File Offset: 0x001473D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EC15 RID: 60437
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC16 RID: 60438 RVA: 0x001491F8 File Offset: 0x001473F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EC17 RID: 60439
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataProbeFilter_GetPassPartialArrays_03(HandleRef pThis);

		/// <summary>
		/// When dealing with composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
		/// other types of arrays i.e int, char etc.
		/// </summary>
		// Token: 0x0600EC18 RID: 60440 RVA: 0x00149214 File Offset: 0x00147414
		public virtual bool GetPassPartialArrays()
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_GetPassPartialArrays_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EC19 RID: 60441
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataProbeFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC1A RID: 60442 RVA: 0x0014923C File Offset: 0x0014743C
		public override int IsA(string type)
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EC1B RID: 60443
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataProbeFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC1C RID: 60444 RVA: 0x0014925C File Offset: 0x0014745C
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600EC1D RID: 60445
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataProbeFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC1E RID: 60446 RVA: 0x00149278 File Offset: 0x00147478
		public new vtkCompositeDataProbeFilter NewInstance()
		{
			vtkCompositeDataProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EC1F RID: 60447
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataProbeFilter_PassPartialArraysOff_08(HandleRef pThis);

		/// <summary>
		/// When dealing with composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
		/// other types of arrays i.e int, char etc.
		/// </summary>
		// Token: 0x0600EC20 RID: 60448 RVA: 0x001492D2 File Offset: 0x001474D2
		public virtual void PassPartialArraysOff()
		{
			vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_PassPartialArraysOff_08(base.GetCppThis());
		}

		// Token: 0x0600EC21 RID: 60449
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataProbeFilter_PassPartialArraysOn_09(HandleRef pThis);

		/// <summary>
		/// When dealing with composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
		/// other types of arrays i.e int, char etc.
		/// </summary>
		// Token: 0x0600EC22 RID: 60450 RVA: 0x001492E1 File Offset: 0x001474E1
		public virtual void PassPartialArraysOn()
		{
			vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_PassPartialArraysOn_09(base.GetCppThis());
		}

		// Token: 0x0600EC23 RID: 60451
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataProbeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC24 RID: 60452 RVA: 0x001492F0 File Offset: 0x001474F0
		public new static vtkCompositeDataProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataProbeFilter vtkCompositeDataProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataProbeFilter = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataProbeFilter.Register(null);
				}
			}
			return vtkCompositeDataProbeFilter;
		}

		// Token: 0x0600EC25 RID: 60453
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataProbeFilter_SetPassPartialArrays_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// When dealing with composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
		/// other types of arrays i.e int, char etc.
		/// </summary>
		// Token: 0x0600EC26 RID: 60454 RVA: 0x0014936F File Offset: 0x0014756F
		public virtual void SetPassPartialArrays(bool _arg)
		{
			vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_SetPassPartialArrays_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400113D RID: 4413
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400113E RID: 4414
		public new static readonly string MRClassNameKey = "class vtkCompositeDataProbeFilter";
	}
}
