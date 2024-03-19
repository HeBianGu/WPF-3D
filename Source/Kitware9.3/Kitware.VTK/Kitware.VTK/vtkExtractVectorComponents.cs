using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractVectorComponents
	/// </summary>
	/// <remarks>
	///    extract components of vector as separate scalars
	///
	/// vtkExtractVectorComponents is a filter that extracts vector components as
	/// separate scalars. This is accomplished by creating three different outputs.
	/// Each output is the same as the input, except that the scalar values will be
	/// one of the three components of the vector. These can be found in the
	/// VxComponent, VyComponent, and VzComponent.
	/// Alternatively, if the ExtractToFieldData flag is set, the filter will
	/// put all the components in the field data. The first component will be
	/// the scalar and the others will be non-attribute arrays.
	///
	/// @warning
	/// This filter is unusual in that it creates multiple outputs.
	/// If you use the GetOutput() method, you will be retrieving the x vector
	/// component.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x020006BD RID: 1725
	public class vtkExtractVectorComponents : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060126C7 RID: 75463 RVA: 0x0019CBC7 File Offset: 0x0019ADC7
		static vtkExtractVectorComponents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractVectorComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractVectorComponents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060126C8 RID: 75464 RVA: 0x0019CBEF File Offset: 0x0019ADEF
		public vtkExtractVectorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060126C9 RID: 75465
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVectorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126CA RID: 75466 RVA: 0x0019CC00 File Offset: 0x0019AE00
		public new static vtkExtractVectorComponents New()
		{
			vtkExtractVectorComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126CB RID: 75467 RVA: 0x0019CC54 File Offset: 0x0019AE54
		public vtkExtractVectorComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractVectorComponents.vtkExtractVectorComponents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060126CC RID: 75468 RVA: 0x0019CC98 File Offset: 0x0019AE98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060126CD RID: 75469
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVectorComponents_ExtractToFieldDataOff_01(HandleRef pThis);

		/// <summary>
		/// Determines whether the vector components will be put
		/// in separate outputs or in the first output's field data
		/// </summary>
		// Token: 0x060126CE RID: 75470 RVA: 0x0019CCA3 File Offset: 0x0019AEA3
		public virtual void ExtractToFieldDataOff()
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_ExtractToFieldDataOff_01(base.GetCppThis());
		}

		// Token: 0x060126CF RID: 75471
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVectorComponents_ExtractToFieldDataOn_02(HandleRef pThis);

		/// <summary>
		/// Determines whether the vector components will be put
		/// in separate outputs or in the first output's field data
		/// </summary>
		// Token: 0x060126D0 RID: 75472 RVA: 0x0019CCB2 File Offset: 0x0019AEB2
		public virtual void ExtractToFieldDataOn()
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_ExtractToFieldDataOn_02(base.GetCppThis());
		}

		// Token: 0x060126D1 RID: 75473
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractVectorComponents_GetExtractToFieldData_03(HandleRef pThis);

		/// <summary>
		/// Determines whether the vector components will be put
		/// in separate outputs or in the first output's field data
		/// </summary>
		// Token: 0x060126D2 RID: 75474 RVA: 0x0019CCC4 File Offset: 0x0019AEC4
		public virtual int GetExtractToFieldData()
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_GetExtractToFieldData_03(base.GetCppThis());
		}

		// Token: 0x060126D3 RID: 75475
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractVectorComponents_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126D4 RID: 75476 RVA: 0x0019CCE4 File Offset: 0x0019AEE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060126D5 RID: 75477
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractVectorComponents_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126D6 RID: 75478 RVA: 0x0019CD04 File Offset: 0x0019AF04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060126D7 RID: 75479
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVectorComponents_GetVxComponent_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output dataset representing velocity x-component. If output is
		/// nullptr then input hasn't been set, which is necessary for abstract
		/// objects. (Note: this method returns the same information as the
		/// GetOutput() method with an index of 0.)
		/// </summary>
		// Token: 0x060126D8 RID: 75480 RVA: 0x0019CD20 File Offset: 0x0019AF20
		public vtkDataSet GetVxComponent()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_GetVxComponent_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060126D9 RID: 75481
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVectorComponents_GetVyComponent_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output dataset representing velocity y-component. If output is
		/// nullptr then input hasn't been set, which is necessary for abstract
		/// objects. (Note: this method returns the same information as the
		/// GetOutput() method with an index of 1.)
		/// Note that if ExtractToFieldData is true, this output will be empty.
		/// </summary>
		// Token: 0x060126DA RID: 75482 RVA: 0x0019CD90 File Offset: 0x0019AF90
		public vtkDataSet GetVyComponent()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_GetVyComponent_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060126DB RID: 75483
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVectorComponents_GetVzComponent_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output dataset representing velocity z-component. If output is
		/// nullptr then input hasn't been set, which is necessary for abstract
		/// objects. (Note: this method returns the same information as the
		/// GetOutput() method with an index of 2.)
		/// Note that if ExtractToFieldData is true, this output will be empty.
		/// </summary>
		// Token: 0x060126DC RID: 75484 RVA: 0x0019CE00 File Offset: 0x0019B000
		public vtkDataSet GetVzComponent()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_GetVzComponent_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060126DD RID: 75485
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractVectorComponents_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126DE RID: 75486 RVA: 0x0019CE70 File Offset: 0x0019B070
		public override int IsA(string type)
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060126DF RID: 75487
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractVectorComponents_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126E0 RID: 75488 RVA: 0x0019CE90 File Offset: 0x0019B090
		public new static int IsTypeOf(string type)
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_IsTypeOf_10(type);
		}

		// Token: 0x060126E1 RID: 75489
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVectorComponents_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126E2 RID: 75490 RVA: 0x0019CEAC File Offset: 0x0019B0AC
		public new vtkExtractVectorComponents NewInstance()
		{
			vtkExtractVectorComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060126E3 RID: 75491
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVectorComponents_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126E4 RID: 75492 RVA: 0x0019CF08 File Offset: 0x0019B108
		public new static vtkExtractVectorComponents SafeDownCast(vtkObjectBase o)
		{
			vtkExtractVectorComponents vtkExtractVectorComponents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractVectorComponents = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractVectorComponents.Register(null);
				}
			}
			return vtkExtractVectorComponents;
		}

		// Token: 0x060126E5 RID: 75493
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVectorComponents_SetExtractToFieldData_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines whether the vector components will be put
		/// in separate outputs or in the first output's field data
		/// </summary>
		// Token: 0x060126E6 RID: 75494 RVA: 0x0019CF87 File Offset: 0x0019B187
		public virtual void SetExtractToFieldData(int _arg)
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_SetExtractToFieldData_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060126E7 RID: 75495
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVectorComponents_SetInputData_15(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Specify the input data or filter.
		/// </summary>
		// Token: 0x060126E8 RID: 75496 RVA: 0x0019CF98 File Offset: 0x0019B198
		public new virtual void SetInputData(vtkDataSet input)
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_SetInputData_15(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400152A RID: 5418
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractVectorComponents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400152B RID: 5419
		public new static readonly string MRClassNameKey = "class vtkExtractVectorComponents";
	}
}
