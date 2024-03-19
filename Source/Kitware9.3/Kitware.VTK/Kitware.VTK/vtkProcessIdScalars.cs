using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProcessIdScalars
	/// </summary>
	/// <remarks>
	///    Sets cell or point scalars to the processor rank.
	///
	///
	/// vtkProcessIdScalars is meant to display which processor owns which cells
	/// and points.  It is useful for visualizing the partitioning for
	/// streaming or distributed pipelines.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataStreamer vtkGenerateProcessIds
	/// </seealso>
	// Token: 0x02000531 RID: 1329
	public class vtkProcessIdScalars : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ED23 RID: 60707 RVA: 0x0014AA5D File Offset: 0x00148C5D
		static vtkProcessIdScalars()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcessIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessIdScalars"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ED24 RID: 60708 RVA: 0x0014AA85 File Offset: 0x00148C85
		public vtkProcessIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ED25 RID: 60709
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED26 RID: 60710 RVA: 0x0014AA94 File Offset: 0x00148C94
		public new static vtkProcessIdScalars New()
		{
			vtkProcessIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED27 RID: 60711 RVA: 0x0014AAE8 File Offset: 0x00148CE8
		public vtkProcessIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProcessIdScalars.vtkProcessIdScalars_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ED28 RID: 60712 RVA: 0x0014AB2C File Offset: 0x00148D2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ED29 RID: 60713
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessIdScalars_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600ED2A RID: 60714 RVA: 0x0014AB38 File Offset: 0x00148D38
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600ED2B RID: 60715
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcessIdScalars_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED2C RID: 60716 RVA: 0x0014ABA8 File Offset: 0x00148DA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600ED2D RID: 60717
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcessIdScalars_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED2E RID: 60718 RVA: 0x0014ABC8 File Offset: 0x00148DC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600ED2F RID: 60719
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessIdScalars_GetRandomMode_04(HandleRef pThis);

		/// <summary>
		/// This option uses a random mapping between pieces and scalar values.
		/// The scalar values are chosen between 0 and 1.  By default, random
		/// mode is off.
		/// </summary>
		// Token: 0x0600ED30 RID: 60720 RVA: 0x0014ABE4 File Offset: 0x00148DE4
		public virtual int GetRandomMode()
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_GetRandomMode_04(base.GetCppThis());
		}

		// Token: 0x0600ED31 RID: 60721
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessIdScalars_GetScalarMode_05(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point
		/// scalars (0).
		/// </summary>
		// Token: 0x0600ED32 RID: 60722 RVA: 0x0014AC04 File Offset: 0x00148E04
		public int GetScalarMode()
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_GetScalarMode_05(base.GetCppThis());
		}

		// Token: 0x0600ED33 RID: 60723
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessIdScalars_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED34 RID: 60724 RVA: 0x0014AC24 File Offset: 0x00148E24
		public override int IsA(string type)
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600ED35 RID: 60725
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessIdScalars_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED36 RID: 60726 RVA: 0x0014AC44 File Offset: 0x00148E44
		public new static int IsTypeOf(string type)
		{
			return vtkProcessIdScalars.vtkProcessIdScalars_IsTypeOf_07(type);
		}

		// Token: 0x0600ED37 RID: 60727
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessIdScalars_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED38 RID: 60728 RVA: 0x0014AC60 File Offset: 0x00148E60
		public new vtkProcessIdScalars NewInstance()
		{
			vtkProcessIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ED39 RID: 60729
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_RandomModeOff_10(HandleRef pThis);

		/// <summary>
		/// This option uses a random mapping between pieces and scalar values.
		/// The scalar values are chosen between 0 and 1.  By default, random
		/// mode is off.
		/// </summary>
		// Token: 0x0600ED3A RID: 60730 RVA: 0x0014ACBA File Offset: 0x00148EBA
		public virtual void RandomModeOff()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_RandomModeOff_10(base.GetCppThis());
		}

		// Token: 0x0600ED3B RID: 60731
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_RandomModeOn_11(HandleRef pThis);

		/// <summary>
		/// This option uses a random mapping between pieces and scalar values.
		/// The scalar values are chosen between 0 and 1.  By default, random
		/// mode is off.
		/// </summary>
		// Token: 0x0600ED3C RID: 60732 RVA: 0x0014ACC9 File Offset: 0x00148EC9
		public virtual void RandomModeOn()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_RandomModeOn_11(base.GetCppThis());
		}

		// Token: 0x0600ED3D RID: 60733
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessIdScalars_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED3E RID: 60734 RVA: 0x0014ACD8 File Offset: 0x00148ED8
		public new static vtkProcessIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkProcessIdScalars vtkProcessIdScalars = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessIdScalars.vtkProcessIdScalars_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcessIdScalars = (vtkProcessIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcessIdScalars.Register(null);
				}
			}
			return vtkProcessIdScalars;
		}

		// Token: 0x0600ED3F RID: 60735
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_SetCellScalarsFlag_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point
		/// scalars (0).
		/// </summary>
		// Token: 0x0600ED40 RID: 60736 RVA: 0x0014AD57 File Offset: 0x00148F57
		public virtual void SetCellScalarsFlag(int _arg)
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetCellScalarsFlag_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ED41 RID: 60737
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_SetController_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// By default this filter uses the global controller,
		/// but this method can be used to set another instead.
		/// </summary>
		// Token: 0x0600ED42 RID: 60738 RVA: 0x0014AD68 File Offset: 0x00148F68
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetController_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600ED43 RID: 60739
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_SetRandomMode_15(HandleRef pThis, int _arg);

		/// <summary>
		/// This option uses a random mapping between pieces and scalar values.
		/// The scalar values are chosen between 0 and 1.  By default, random
		/// mode is off.
		/// </summary>
		// Token: 0x0600ED44 RID: 60740 RVA: 0x0014AD97 File Offset: 0x00148F97
		public virtual void SetRandomMode(int _arg)
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetRandomMode_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ED45 RID: 60741
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_SetScalarModeToCellData_16(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point
		/// scalars (0).
		/// </summary>
		// Token: 0x0600ED46 RID: 60742 RVA: 0x0014ADA7 File Offset: 0x00148FA7
		public void SetScalarModeToCellData()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetScalarModeToCellData_16(base.GetCppThis());
		}

		// Token: 0x0600ED47 RID: 60743
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessIdScalars_SetScalarModeToPointData_17(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point
		/// scalars (0).
		/// </summary>
		// Token: 0x0600ED48 RID: 60744 RVA: 0x0014ADB6 File Offset: 0x00148FB6
		public void SetScalarModeToPointData()
		{
			vtkProcessIdScalars.vtkProcessIdScalars_SetScalarModeToPointData_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400115A RID: 4442
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcessIdScalars";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400115B RID: 4443
		public new static readonly string MRClassNameKey = "class vtkProcessIdScalars";
	}
}
