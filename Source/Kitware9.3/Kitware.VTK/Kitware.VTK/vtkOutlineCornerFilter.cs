using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutlineCornerFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline corners for arbitrary data set
	///
	/// vtkOutlineCornerFilter is a filter that generates wireframe outline corners of any
	/// data set. The outline consists of the eight corners of the dataset
	/// bounding box.
	/// </remarks>
	// Token: 0x0200082E RID: 2094
	public class vtkOutlineCornerFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015AA2 RID: 88738 RVA: 0x001E959E File Offset: 0x001E779E
		static vtkOutlineCornerFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineCornerFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineCornerFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015AA3 RID: 88739 RVA: 0x001E95C6 File Offset: 0x001E77C6
		public vtkOutlineCornerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015AA4 RID: 88740
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineCornerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct outline corner filter with default corner factor = 0.2
		/// </summary>
		// Token: 0x06015AA5 RID: 88741 RVA: 0x001E95D4 File Offset: 0x001E77D4
		public new static vtkOutlineCornerFilter New()
		{
			vtkOutlineCornerFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineCornerFilter.vtkOutlineCornerFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct outline corner filter with default corner factor = 0.2
		/// </summary>
		// Token: 0x06015AA6 RID: 88742 RVA: 0x001E9628 File Offset: 0x001E7828
		public vtkOutlineCornerFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutlineCornerFilter.vtkOutlineCornerFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015AA7 RID: 88743 RVA: 0x001E966C File Offset: 0x001E786C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015AA8 RID: 88744
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOutlineCornerFilter_GetCornerFactor_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015AA9 RID: 88745 RVA: 0x001E9678 File Offset: 0x001E7878
		public virtual double GetCornerFactor()
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetCornerFactor_01(base.GetCppThis());
		}

		// Token: 0x06015AAA RID: 88746
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOutlineCornerFilter_GetCornerFactorMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015AAB RID: 88747 RVA: 0x001E9698 File Offset: 0x001E7898
		public virtual double GetCornerFactorMaxValue()
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetCornerFactorMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06015AAC RID: 88748
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOutlineCornerFilter_GetCornerFactorMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015AAD RID: 88749 RVA: 0x001E96B8 File Offset: 0x001E78B8
		public virtual double GetCornerFactorMinValue()
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetCornerFactorMinValue_03(base.GetCppThis());
		}

		// Token: 0x06015AAE RID: 88750
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineCornerFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AAF RID: 88751 RVA: 0x001E96D8 File Offset: 0x001E78D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06015AB0 RID: 88752
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineCornerFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AB1 RID: 88753 RVA: 0x001E96F8 File Offset: 0x001E78F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06015AB2 RID: 88754
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineCornerFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AB3 RID: 88755 RVA: 0x001E9714 File Offset: 0x001E7914
		public override int IsA(string type)
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06015AB4 RID: 88756
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineCornerFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AB5 RID: 88757 RVA: 0x001E9734 File Offset: 0x001E7934
		public new static int IsTypeOf(string type)
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_IsTypeOf_07(type);
		}

		// Token: 0x06015AB6 RID: 88758
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineCornerFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AB7 RID: 88759 RVA: 0x001E9750 File Offset: 0x001E7950
		public new vtkOutlineCornerFilter NewInstance()
		{
			vtkOutlineCornerFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineCornerFilter.vtkOutlineCornerFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015AB8 RID: 88760
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineCornerFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AB9 RID: 88761 RVA: 0x001E97AC File Offset: 0x001E79AC
		public new static vtkOutlineCornerFilter SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineCornerFilter vtkOutlineCornerFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineCornerFilter.vtkOutlineCornerFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineCornerFilter = (vtkOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineCornerFilter.Register(null);
				}
			}
			return vtkOutlineCornerFilter;
		}

		// Token: 0x06015ABA RID: 88762
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineCornerFilter_SetCornerFactor_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015ABB RID: 88763 RVA: 0x001E982B File Offset: 0x001E7A2B
		public virtual void SetCornerFactor(double _arg)
		{
			vtkOutlineCornerFilter.vtkOutlineCornerFilter_SetCornerFactor_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A6 RID: 6310
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineCornerFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A7 RID: 6311
		public new static readonly string MRClassNameKey = "class vtkOutlineCornerFilter";
	}
}
