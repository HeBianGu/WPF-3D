using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderedHierarchyRepresentation
	///
	///
	/// </summary>
	// Token: 0x02000082 RID: 130
	public class vtkRenderedHierarchyRepresentation : vtkRenderedGraphRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060018E8 RID: 6376 RVA: 0x0002851E File Offset: 0x0002671E
		static vtkRenderedHierarchyRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedHierarchyRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedHierarchyRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060018E9 RID: 6377 RVA: 0x00028546 File Offset: 0x00026746
		public vtkRenderedHierarchyRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060018EA RID: 6378
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018EB RID: 6379 RVA: 0x00028554 File Offset: 0x00026754
		public new static vtkRenderedHierarchyRepresentation New()
		{
			vtkRenderedHierarchyRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018EC RID: 6380 RVA: 0x000285A8 File Offset: 0x000267A8
		public vtkRenderedHierarchyRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060018ED RID: 6381 RVA: 0x000285EC File Offset: 0x000267EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060018EE RID: 6382
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOff_01(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018EF RID: 6383 RVA: 0x000285F7 File Offset: 0x000267F7
		public virtual void ColorGraphEdgesByArrayOff()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOff_01(base.GetCppThis());
		}

		// Token: 0x060018F0 RID: 6384
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOn_02(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018F1 RID: 6385 RVA: 0x00028606 File Offset: 0x00026806
		public virtual void ColorGraphEdgesByArrayOn()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_ColorGraphEdgesByArrayOn_02(base.GetCppThis());
		}

		// Token: 0x060018F2 RID: 6386
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderedHierarchyRepresentation_GetBundlingStrength_03(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018F3 RID: 6387 RVA: 0x00028618 File Offset: 0x00026818
		public virtual double GetBundlingStrength()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetBundlingStrength_03(base.GetCppThis());
		}

		// Token: 0x060018F4 RID: 6388
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderedHierarchyRepresentation_GetBundlingStrength_04(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018F5 RID: 6389 RVA: 0x00028638 File Offset: 0x00026838
		public virtual double GetBundlingStrength(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetBundlingStrength_04(base.GetCppThis(), idx);
		}

		// Token: 0x060018F6 RID: 6390
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_05(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018F7 RID: 6391 RVA: 0x00028658 File Offset: 0x00026858
		public virtual bool GetColorGraphEdgesByArray()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060018F8 RID: 6392
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_06(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018F9 RID: 6393 RVA: 0x00028680 File Offset: 0x00026880
		public virtual bool GetColorGraphEdgesByArray(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetColorGraphEdgesByArray_06(base.GetCppThis(), idx) != 0;
		}

		// Token: 0x060018FA RID: 6394
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_07(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018FB RID: 6395 RVA: 0x000286A8 File Offset: 0x000268A8
		public virtual string GetGraphEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060018FC RID: 6396
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_08(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018FD RID: 6397 RVA: 0x000286E4 File Offset: 0x000268E4
		public virtual string GetGraphEdgeColorArrayName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeColorArrayName_08(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060018FE RID: 6398
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_09(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x060018FF RID: 6399 RVA: 0x00028720 File Offset: 0x00026920
		public virtual string GetGraphEdgeLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001900 RID: 6400
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_10(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001901 RID: 6401 RVA: 0x0002875C File Offset: 0x0002695C
		public virtual string GetGraphEdgeLabelArrayName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelArrayName_10(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001902 RID: 6402
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_11(HandleRef pThis);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x06001903 RID: 6403 RVA: 0x00028798 File Offset: 0x00026998
		public virtual int GetGraphEdgeLabelFontSize()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_11(base.GetCppThis());
		}

		// Token: 0x06001904 RID: 6404
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_12(HandleRef pThis, int idx);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x06001905 RID: 6405 RVA: 0x000287B8 File Offset: 0x000269B8
		public virtual int GetGraphEdgeLabelFontSize(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelFontSize_12(base.GetCppThis(), idx);
		}

		// Token: 0x06001906 RID: 6406
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_13(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001907 RID: 6407 RVA: 0x000287D8 File Offset: 0x000269D8
		public virtual bool GetGraphEdgeLabelVisibility()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06001908 RID: 6408
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_14(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001909 RID: 6409 RVA: 0x00028800 File Offset: 0x00026A00
		public virtual bool GetGraphEdgeLabelVisibility(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphEdgeLabelVisibility_14(base.GetCppThis(), idx) != 0;
		}

		// Token: 0x0600190A RID: 6410
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedHierarchyRepresentation_GetGraphSplineType_15(HandleRef pThis, int idx);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x0600190B RID: 6411 RVA: 0x00028828 File Offset: 0x00026A28
		public virtual int GetGraphSplineType(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphSplineType_15(base.GetCppThis(), idx);
		}

		// Token: 0x0600190C RID: 6412
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphVisibility_16(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600190D RID: 6413 RVA: 0x00028848 File Offset: 0x00026A48
		public virtual bool GetGraphVisibility()
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphVisibility_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600190E RID: 6414
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedHierarchyRepresentation_GetGraphVisibility_17(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600190F RID: 6415 RVA: 0x00028870 File Offset: 0x00026A70
		public virtual bool GetGraphVisibility(int idx)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetGraphVisibility_17(base.GetCppThis(), idx) != 0;
		}

		// Token: 0x06001910 RID: 6416
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001911 RID: 6417 RVA: 0x00028898 File Offset: 0x00026A98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06001912 RID: 6418
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001913 RID: 6419 RVA: 0x000288B8 File Offset: 0x00026AB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06001914 RID: 6420
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOff_20(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001915 RID: 6421 RVA: 0x000288D2 File Offset: 0x00026AD2
		public virtual void GraphEdgeLabelVisibilityOff()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOff_20(base.GetCppThis());
		}

		// Token: 0x06001916 RID: 6422
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOn_21(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001917 RID: 6423 RVA: 0x000288E1 File Offset: 0x00026AE1
		public virtual void GraphEdgeLabelVisibilityOn()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphEdgeLabelVisibilityOn_21(base.GetCppThis());
		}

		// Token: 0x06001918 RID: 6424
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphVisibilityOff_22(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001919 RID: 6425 RVA: 0x000288F0 File Offset: 0x00026AF0
		public virtual void GraphVisibilityOff()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphVisibilityOff_22(base.GetCppThis());
		}

		// Token: 0x0600191A RID: 6426
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_GraphVisibilityOn_23(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600191B RID: 6427 RVA: 0x000288FF File Offset: 0x00026AFF
		public virtual void GraphVisibilityOn()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_GraphVisibilityOn_23(base.GetCppThis());
		}

		// Token: 0x0600191C RID: 6428
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedHierarchyRepresentation_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600191D RID: 6429 RVA: 0x00028910 File Offset: 0x00026B10
		public override int IsA(string type)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600191E RID: 6430
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedHierarchyRepresentation_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600191F RID: 6431 RVA: 0x00028930 File Offset: 0x00026B30
		public new static int IsTypeOf(string type)
		{
			return vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_IsTypeOf_25(type);
		}

		// Token: 0x06001920 RID: 6432
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001921 RID: 6433 RVA: 0x0002894C File Offset: 0x00026B4C
		public new vtkRenderedHierarchyRepresentation NewInstance()
		{
			vtkRenderedHierarchyRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001922 RID: 6434
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedHierarchyRepresentation_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001923 RID: 6435 RVA: 0x000289A8 File Offset: 0x00026BA8
		public new static vtkRenderedHierarchyRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedHierarchyRepresentation vtkRenderedHierarchyRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedHierarchyRepresentation = (vtkRenderedHierarchyRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedHierarchyRepresentation.Register(null);
				}
			}
			return vtkRenderedHierarchyRepresentation;
		}

		// Token: 0x06001924 RID: 6436
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetBundlingStrength_29(HandleRef pThis, double strength);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001925 RID: 6437 RVA: 0x00028A27 File Offset: 0x00026C27
		public virtual void SetBundlingStrength(double strength)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetBundlingStrength_29(base.GetCppThis(), strength);
		}

		// Token: 0x06001926 RID: 6438
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetBundlingStrength_30(HandleRef pThis, double strength, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001927 RID: 6439 RVA: 0x00028A37 File Offset: 0x00026C37
		public virtual void SetBundlingStrength(double strength, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetBundlingStrength_30(base.GetCppThis(), strength, idx);
		}

		// Token: 0x06001928 RID: 6440
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_31(HandleRef pThis, byte vis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001929 RID: 6441 RVA: 0x00028A48 File Offset: 0x00026C48
		public virtual void SetColorGraphEdgesByArray(bool vis)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_31(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600192A RID: 6442
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_32(HandleRef pThis, byte vis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600192B RID: 6443 RVA: 0x00028A60 File Offset: 0x00026C60
		public virtual void SetColorGraphEdgesByArray(bool vis, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetColorGraphEdgesByArray_32(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		// Token: 0x0600192C RID: 6444
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600192D RID: 6445 RVA: 0x00028A79 File Offset: 0x00026C79
		public virtual void SetGraphEdgeColorArrayName(string name)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_33(base.GetCppThis(), name);
		}

		// Token: 0x0600192E RID: 6446
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600192F RID: 6447 RVA: 0x00028A89 File Offset: 0x00026C89
		public virtual void SetGraphEdgeColorArrayName(string name, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorArrayName_34(base.GetCppThis(), name, idx);
		}

		// Token: 0x06001930 RID: 6448
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_35(HandleRef pThis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001931 RID: 6449 RVA: 0x00028A9A File Offset: 0x00026C9A
		public virtual void SetGraphEdgeColorToSplineFraction()
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_35(base.GetCppThis());
		}

		// Token: 0x06001932 RID: 6450
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_36(HandleRef pThis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001933 RID: 6451 RVA: 0x00028AA9 File Offset: 0x00026CA9
		public virtual void SetGraphEdgeColorToSplineFraction(int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeColorToSplineFraction_36(base.GetCppThis(), idx);
		}

		// Token: 0x06001934 RID: 6452
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001935 RID: 6453 RVA: 0x00028AB9 File Offset: 0x00026CB9
		public virtual void SetGraphEdgeLabelArrayName(string name)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_37(base.GetCppThis(), name);
		}

		// Token: 0x06001936 RID: 6454
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001937 RID: 6455 RVA: 0x00028AC9 File Offset: 0x00026CC9
		public virtual void SetGraphEdgeLabelArrayName(string name, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelArrayName_38(base.GetCppThis(), name, idx);
		}

		// Token: 0x06001938 RID: 6456
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_39(HandleRef pThis, int size);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x06001939 RID: 6457 RVA: 0x00028ADA File Offset: 0x00026CDA
		public virtual void SetGraphEdgeLabelFontSize(int size)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_39(base.GetCppThis(), size);
		}

		// Token: 0x0600193A RID: 6458
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_40(HandleRef pThis, int size, int idx);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x0600193B RID: 6459 RVA: 0x00028AEA File Offset: 0x00026CEA
		public virtual void SetGraphEdgeLabelFontSize(int size, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelFontSize_40(base.GetCppThis(), size, idx);
		}

		// Token: 0x0600193C RID: 6460
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_41(HandleRef pThis, byte vis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600193D RID: 6461 RVA: 0x00028AFB File Offset: 0x00026CFB
		public virtual void SetGraphEdgeLabelVisibility(bool vis)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_41(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600193E RID: 6462
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_42(HandleRef pThis, byte vis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600193F RID: 6463 RVA: 0x00028B13 File Offset: 0x00026D13
		public virtual void SetGraphEdgeLabelVisibility(bool vis, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphEdgeLabelVisibility_42(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		// Token: 0x06001940 RID: 6464
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphSplineType_43(HandleRef pThis, int type, int idx);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x06001941 RID: 6465 RVA: 0x00028B2C File Offset: 0x00026D2C
		public virtual void SetGraphSplineType(int type, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphSplineType_43(base.GetCppThis(), type, idx);
		}

		// Token: 0x06001942 RID: 6466
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphVisibility_44(HandleRef pThis, byte vis);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001943 RID: 6467 RVA: 0x00028B3D File Offset: 0x00026D3D
		public virtual void SetGraphVisibility(bool vis)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphVisibility_44(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001944 RID: 6468
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedHierarchyRepresentation_SetGraphVisibility_45(HandleRef pThis, byte vis, int idx);

		/// <summary>
		///
		/// </summary>
		// Token: 0x06001945 RID: 6469 RVA: 0x00028B55 File Offset: 0x00026D55
		public virtual void SetGraphVisibility(bool vis, int idx)
		{
			vtkRenderedHierarchyRepresentation.vtkRenderedHierarchyRepresentation_SetGraphVisibility_45(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A2 RID: 1186
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedHierarchyRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A3 RID: 1187
		public new static readonly string MRClassNameKey = "class vtkRenderedHierarchyRepresentation";
	}
}
