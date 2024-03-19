using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPOutlineCornerFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline corners for arbitrary data set
	///
	/// vtkPOutlineCornerFilter works like vtkOutlineCornerFilter,
	/// but it looks for data
	/// partitions in other processes.  It assumes the filter is operated
	/// in a data parallel pipeline.
	/// </remarks>
	// Token: 0x02000521 RID: 1313
	public class vtkPOutlineCornerFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EAFA RID: 60154 RVA: 0x00147B3B File Offset: 0x00145D3B
		static vtkPOutlineCornerFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOutlineCornerFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOutlineCornerFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAFB RID: 60155 RVA: 0x00147B63 File Offset: 0x00145D63
		public vtkPOutlineCornerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EAFC RID: 60156
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineCornerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct outline corner filter with default corner factor = 0.2
		/// </summary>
		// Token: 0x0600EAFD RID: 60157 RVA: 0x00147B74 File Offset: 0x00145D74
		public new static vtkPOutlineCornerFilter New()
		{
			vtkPOutlineCornerFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct outline corner filter with default corner factor = 0.2
		/// </summary>
		// Token: 0x0600EAFE RID: 60158 RVA: 0x00147BC8 File Offset: 0x00145DC8
		public vtkPOutlineCornerFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAFF RID: 60159 RVA: 0x00147C0C File Offset: 0x00145E0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EB00 RID: 60160
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineCornerFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600EB01 RID: 60161 RVA: 0x00147C18 File Offset: 0x00145E18
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EB02 RID: 60162
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPOutlineCornerFilter_GetCornerFactor_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
		/// used but since we are chaining this to an internal method we rewrite
		/// the code in the macro
		/// </summary>
		// Token: 0x0600EB03 RID: 60163 RVA: 0x00147C88 File Offset: 0x00145E88
		public virtual double GetCornerFactor()
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetCornerFactor_02(base.GetCppThis());
		}

		// Token: 0x0600EB04 RID: 60164
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPOutlineCornerFilter_GetCornerFactorMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
		/// used but since we are chaining this to an internal method we rewrite
		/// the code in the macro
		/// </summary>
		// Token: 0x0600EB05 RID: 60165 RVA: 0x00147CA8 File Offset: 0x00145EA8
		public virtual double GetCornerFactorMaxValue()
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetCornerFactorMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600EB06 RID: 60166
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPOutlineCornerFilter_GetCornerFactorMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
		/// used but since we are chaining this to an internal method we rewrite
		/// the code in the macro
		/// </summary>
		// Token: 0x0600EB07 RID: 60167 RVA: 0x00147CC8 File Offset: 0x00145EC8
		public virtual double GetCornerFactorMinValue()
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetCornerFactorMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600EB08 RID: 60168
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB09 RID: 60169 RVA: 0x00147CE8 File Offset: 0x00145EE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600EB0A RID: 60170
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB0B RID: 60171 RVA: 0x00147D08 File Offset: 0x00145F08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600EB0C RID: 60172
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOutlineCornerFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB0D RID: 60173 RVA: 0x00147D24 File Offset: 0x00145F24
		public override int IsA(string type)
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600EB0E RID: 60174
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOutlineCornerFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB0F RID: 60175 RVA: 0x00147D44 File Offset: 0x00145F44
		public new static int IsTypeOf(string type)
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_IsTypeOf_08(type);
		}

		// Token: 0x0600EB10 RID: 60176
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineCornerFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB11 RID: 60177 RVA: 0x00147D60 File Offset: 0x00145F60
		public new vtkPOutlineCornerFilter NewInstance()
		{
			vtkPOutlineCornerFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EB12 RID: 60178
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineCornerFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB13 RID: 60179 RVA: 0x00147DBC File Offset: 0x00145FBC
		public new static vtkPOutlineCornerFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPOutlineCornerFilter vtkPOutlineCornerFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOutlineCornerFilter = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOutlineCornerFilter.Register(null);
				}
			}
			return vtkPOutlineCornerFilter;
		}

		// Token: 0x0600EB14 RID: 60180
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOutlineCornerFilter_SetController_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600EB15 RID: 60181 RVA: 0x00147E3C File Offset: 0x0014603C
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600EB16 RID: 60182
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOutlineCornerFilter_SetCornerFactor_13(HandleRef pThis, double cornerFactor);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
		/// used but since we are chaining this to an internal method we rewrite
		/// the code in the macro
		/// </summary>
		// Token: 0x0600EB17 RID: 60183 RVA: 0x00147E6B File Offset: 0x0014606B
		public virtual void SetCornerFactor(double cornerFactor)
		{
			vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_SetCornerFactor_13(base.GetCppThis(), cornerFactor);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001131 RID: 4401
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOutlineCornerFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001132 RID: 4402
		public new static readonly string MRClassNameKey = "class vtkPOutlineCornerFilter";
	}
}
