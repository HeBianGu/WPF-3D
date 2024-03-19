using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeMapView
	/// </summary>
	/// <remarks>
	///    Displays a tree as a tree map.
	///
	///
	/// vtkTreeMapView shows a vtkTree in a tree map, where each vertex in the
	/// tree is represented by a box.  Child boxes are contained within the
	/// parent box, and may be colored and sized by various parameters.
	/// </remarks>
	// Token: 0x02000089 RID: 137
	public class vtkTreeMapView : vtkTreeAreaView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001AE1 RID: 6881 RVA: 0x0002ADA3 File Offset: 0x00028FA3
		static vtkTreeMapView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001AE2 RID: 6882 RVA: 0x0002ADCB File Offset: 0x00028FCB
		public vtkTreeMapView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001AE3 RID: 6883
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AE4 RID: 6884 RVA: 0x0002ADDC File Offset: 0x00028FDC
		public new static vtkTreeMapView New()
		{
			vtkTreeMapView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapView.vtkTreeMapView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AE5 RID: 6885 RVA: 0x0002AE30 File Offset: 0x00029030
		public vtkTreeMapView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeMapView.vtkTreeMapView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001AE6 RID: 6886 RVA: 0x0002AE74 File Offset: 0x00029074
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001AE7 RID: 6887
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_GetFontSizeRange_01(HandleRef pThis, IntPtr range);

		/// <summary>
		/// The sizes of the fonts used for labeling.
		/// </summary>
		// Token: 0x06001AE8 RID: 6888 RVA: 0x0002AE7F File Offset: 0x0002907F
		public virtual void GetFontSizeRange(IntPtr range)
		{
			vtkTreeMapView.vtkTreeMapView_GetFontSizeRange_01(base.GetCppThis(), range);
		}

		// Token: 0x06001AE9 RID: 6889
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapView_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AEA RID: 6890 RVA: 0x0002AE90 File Offset: 0x00029090
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeMapView.vtkTreeMapView_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06001AEB RID: 6891
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapView_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AEC RID: 6892 RVA: 0x0002AEB0 File Offset: 0x000290B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeMapView.vtkTreeMapView_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06001AED RID: 6893
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapView_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AEE RID: 6894 RVA: 0x0002AECC File Offset: 0x000290CC
		public override int IsA(string type)
		{
			return vtkTreeMapView.vtkTreeMapView_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06001AEF RID: 6895
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapView_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AF0 RID: 6896 RVA: 0x0002AEEC File Offset: 0x000290EC
		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapView.vtkTreeMapView_IsTypeOf_05(type);
		}

		// Token: 0x06001AF1 RID: 6897
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapView_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AF2 RID: 6898 RVA: 0x0002AF08 File Offset: 0x00029108
		public new vtkTreeMapView NewInstance()
		{
			vtkTreeMapView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapView.vtkTreeMapView_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001AF3 RID: 6899
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapView_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AF4 RID: 6900 RVA: 0x0002AF64 File Offset: 0x00029164
		public new static vtkTreeMapView SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapView vtkTreeMapView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapView.vtkTreeMapView_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapView = (vtkTreeMapView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapView.Register(null);
				}
			}
			return vtkTreeMapView;
		}

		// Token: 0x06001AF5 RID: 6901
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_SetFontSizeRange_09(HandleRef pThis, int maxSize, int minSize, int delta);

		/// <summary>
		/// The sizes of the fonts used for labeling.
		/// </summary>
		// Token: 0x06001AF6 RID: 6902 RVA: 0x0002AFE3 File Offset: 0x000291E3
		public virtual void SetFontSizeRange(int maxSize, int minSize, int delta)
		{
			vtkTreeMapView.vtkTreeMapView_SetFontSizeRange_09(base.GetCppThis(), maxSize, minSize, delta);
		}

		// Token: 0x06001AF7 RID: 6903
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_SetLayoutStrategy_10(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Sets the treemap layout strategy
		/// </summary>
		// Token: 0x06001AF8 RID: 6904 RVA: 0x0002AFF8 File Offset: 0x000291F8
		public override void SetLayoutStrategy(vtkAreaLayoutStrategy s)
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategy_10(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x06001AF9 RID: 6905
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_SetLayoutStrategy_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Sets the treemap layout strategy
		/// </summary>
		// Token: 0x06001AFA RID: 6906 RVA: 0x0002B027 File Offset: 0x00029227
		public virtual void SetLayoutStrategy(string name)
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategy_11(base.GetCppThis(), name);
		}

		// Token: 0x06001AFB RID: 6907
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_SetLayoutStrategyToBox_12(HandleRef pThis);

		/// <summary>
		/// Sets the treemap layout strategy
		/// </summary>
		// Token: 0x06001AFC RID: 6908 RVA: 0x0002B037 File Offset: 0x00029237
		public virtual void SetLayoutStrategyToBox()
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategyToBox_12(base.GetCppThis());
		}

		// Token: 0x06001AFD RID: 6909
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_SetLayoutStrategyToSliceAndDice_13(HandleRef pThis);

		/// <summary>
		/// Sets the treemap layout strategy
		/// </summary>
		// Token: 0x06001AFE RID: 6910 RVA: 0x0002B046 File Offset: 0x00029246
		public virtual void SetLayoutStrategyToSliceAndDice()
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategyToSliceAndDice_13(base.GetCppThis());
		}

		// Token: 0x06001AFF RID: 6911
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapView_SetLayoutStrategyToSquarify_14(HandleRef pThis);

		/// <summary>
		/// Sets the treemap layout strategy
		/// </summary>
		// Token: 0x06001B00 RID: 6912 RVA: 0x0002B055 File Offset: 0x00029255
		public virtual void SetLayoutStrategyToSquarify()
		{
			vtkTreeMapView.vtkTreeMapView_SetLayoutStrategyToSquarify_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B0 RID: 1200
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B1 RID: 1201
		public new static readonly string MRClassNameKey = "class vtkTreeMapView";
	}
}
