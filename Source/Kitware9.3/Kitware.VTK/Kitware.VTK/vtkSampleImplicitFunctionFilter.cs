using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSampleImplicitFunctionFilter
	/// </summary>
	/// <remarks>
	///    sample an implicit function over a dataset,
	/// generating scalar values and optional gradient vectors
	///
	///
	/// vtkSampleImplicitFunctionFilter is a filter that evaluates an implicit function and
	/// (optional) gradients at each point in an input vtkDataSet. The output
	/// of the filter are new scalar values (the function values) and the
	/// optional vector (function gradient) array.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSampleFunction vtkImplicitModeller
	/// </seealso>
	// Token: 0x020008DB RID: 2267
	public class vtkSampleImplicitFunctionFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060176EB RID: 95979 RVA: 0x0020DF82 File Offset: 0x0020C182
		static vtkSampleImplicitFunctionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSampleImplicitFunctionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSampleImplicitFunctionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060176EC RID: 95980 RVA: 0x0020DFAA File Offset: 0x0020C1AA
		public vtkSampleImplicitFunctionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060176ED RID: 95981
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleImplicitFunctionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x060176EE RID: 95982 RVA: 0x0020DFB8 File Offset: 0x0020C1B8
		public new static vtkSampleImplicitFunctionFilter New()
		{
			vtkSampleImplicitFunctionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSampleImplicitFunctionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x060176EF RID: 95983 RVA: 0x0020E00C File Offset: 0x0020C20C
		public vtkSampleImplicitFunctionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060176F0 RID: 95984 RVA: 0x0020E050 File Offset: 0x0020C250
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060176F1 RID: 95985
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleImplicitFunctionFilter_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of gradients.
		/// </summary>
		// Token: 0x060176F2 RID: 95986 RVA: 0x0020E05B File Offset: 0x0020C25B
		public virtual void ComputeGradientsOff()
		{
			vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x060176F3 RID: 95987
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleImplicitFunctionFilter_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of gradients.
		/// </summary>
		// Token: 0x060176F4 RID: 95988 RVA: 0x0020E06A File Offset: 0x0020C26A
		public virtual void ComputeGradientsOn()
		{
			vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x060176F5 RID: 95989
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleImplicitFunctionFilter_GetComputeGradients_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of gradients.
		/// </summary>
		// Token: 0x060176F6 RID: 95990 RVA: 0x0020E07C File Offset: 0x0020C27C
		public virtual int GetComputeGradients()
		{
			return vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetComputeGradients_03(base.GetCppThis());
		}

		// Token: 0x060176F7 RID: 95991
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleImplicitFunctionFilter_GetGradientArrayName_04(HandleRef pThis);

		/// <summary>
		/// Set/get the gradient array name for this data set. The initial value is
		/// "Implicit gradients".
		/// </summary>
		// Token: 0x060176F8 RID: 95992 RVA: 0x0020E09C File Offset: 0x0020C29C
		public virtual string GetGradientArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetGradientArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060176F9 RID: 95993
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleImplicitFunctionFilter_GetImplicitFunction_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to use to generate data.
		/// </summary>
		// Token: 0x060176FA RID: 95994 RVA: 0x0020E0D8 File Offset: 0x0020C2D8
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetImplicitFunction_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x060176FB RID: 95995
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSampleImplicitFunctionFilter_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Return the MTime also taking into account the implicit function.
		/// </summary>
		// Token: 0x060176FC RID: 95996 RVA: 0x0020E148 File Offset: 0x0020C348
		public override ulong GetMTime()
		{
			return vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x060176FD RID: 95997
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x060176FE RID: 95998 RVA: 0x0020E168 File Offset: 0x0020C368
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060176FF RID: 95999
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x06017700 RID: 96000 RVA: 0x0020E188 File Offset: 0x0020C388
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06017701 RID: 96001
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleImplicitFunctionFilter_GetScalarArrayName_09(HandleRef pThis);

		/// <summary>
		/// Set/get the scalar array name for this data set. The initial value is
		/// "Implicit scalars".
		/// </summary>
		// Token: 0x06017702 RID: 96002 RVA: 0x0020E1A4 File Offset: 0x0020C3A4
		public virtual string GetScalarArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_GetScalarArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017703 RID: 96003
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleImplicitFunctionFilter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x06017704 RID: 96004 RVA: 0x0020E1E0 File Offset: 0x0020C3E0
		public override int IsA(string type)
		{
			return vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06017705 RID: 96005
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleImplicitFunctionFilter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x06017706 RID: 96006 RVA: 0x0020E200 File Offset: 0x0020C400
		public new static int IsTypeOf(string type)
		{
			return vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_IsTypeOf_11(type);
		}

		// Token: 0x06017707 RID: 96007
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleImplicitFunctionFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x06017708 RID: 96008 RVA: 0x0020E21C File Offset: 0x0020C41C
		public new vtkSampleImplicitFunctionFilter NewInstance()
		{
			vtkSampleImplicitFunctionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSampleImplicitFunctionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017709 RID: 96009
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleImplicitFunctionFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type information, and print methods.
		/// </summary>
		// Token: 0x0601770A RID: 96010 RVA: 0x0020E278 File Offset: 0x0020C478
		public new static vtkSampleImplicitFunctionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSampleImplicitFunctionFilter vtkSampleImplicitFunctionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSampleImplicitFunctionFilter = (vtkSampleImplicitFunctionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSampleImplicitFunctionFilter.Register(null);
				}
			}
			return vtkSampleImplicitFunctionFilter;
		}

		// Token: 0x0601770B RID: 96011
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleImplicitFunctionFilter_SetComputeGradients_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of gradients.
		/// </summary>
		// Token: 0x0601770C RID: 96012 RVA: 0x0020E2F7 File Offset: 0x0020C4F7
		public virtual void SetComputeGradients(int _arg)
		{
			vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_SetComputeGradients_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601770D RID: 96013
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleImplicitFunctionFilter_SetGradientArrayName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the gradient array name for this data set. The initial value is
		/// "Implicit gradients".
		/// </summary>
		// Token: 0x0601770E RID: 96014 RVA: 0x0020E307 File Offset: 0x0020C507
		public virtual void SetGradientArrayName(string _arg)
		{
			vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_SetGradientArrayName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601770F RID: 96015
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleImplicitFunctionFilter_SetImplicitFunction_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to use to generate data.
		/// </summary>
		// Token: 0x06017710 RID: 96016 RVA: 0x0020E318 File Offset: 0x0020C518
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_SetImplicitFunction_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017711 RID: 96017
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleImplicitFunctionFilter_SetScalarArrayName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the scalar array name for this data set. The initial value is
		/// "Implicit scalars".
		/// </summary>
		// Token: 0x06017712 RID: 96018 RVA: 0x0020E347 File Offset: 0x0020C547
		public virtual void SetScalarArrayName(string _arg)
		{
			vtkSampleImplicitFunctionFilter.vtkSampleImplicitFunctionFilter_SetScalarArrayName_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A2B RID: 6699
		public new const string MRFullTypeName = "Kitware.VTK.vtkSampleImplicitFunctionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A2C RID: 6700
		public new static readonly string MRClassNameKey = "class vtkSampleImplicitFunctionFilter";
	}
}
