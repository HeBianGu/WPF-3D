using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeRingView
	/// </summary>
	/// <remarks>
	///    Displays a tree in concentric rings.
	///
	///
	/// Accepts a graph and a hierarchy - currently
	/// a tree - and provides a hierarchy-aware display.  Currently, this means
	/// displaying the hierarchy using a tree ring layout, then rendering the graph
	/// vertices as leaves of the tree with curved graph edges between leaves.
	///
	/// .SEE ALSO
	/// vtkGraphLayoutView
	///
	/// @par Thanks:
	/// Thanks to Jason Shepherd for implementing this class
	/// </remarks>
	// Token: 0x0200008A RID: 138
	public class vtkTreeRingView : vtkTreeAreaView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001B01 RID: 6913 RVA: 0x0002B064 File Offset: 0x00029264
		static vtkTreeRingView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeRingView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeRingView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001B02 RID: 6914 RVA: 0x0002B08C File Offset: 0x0002928C
		public vtkTreeRingView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001B03 RID: 6915
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeRingView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B04 RID: 6916 RVA: 0x0002B09C File Offset: 0x0002929C
		public new static vtkTreeRingView New()
		{
			vtkTreeRingView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeRingView.vtkTreeRingView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B05 RID: 6917 RVA: 0x0002B0F0 File Offset: 0x000292F0
		public vtkTreeRingView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeRingView.vtkTreeRingView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001B06 RID: 6918 RVA: 0x0002B134 File Offset: 0x00029334
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001B07 RID: 6919
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeRingView_GetInteriorLogSpacingValue_01(HandleRef pThis);

		/// <summary>
		/// Set the log spacing factor for the invisible interior tree
		/// used for routing edges of the overlaid graph.
		/// </summary>
		// Token: 0x06001B08 RID: 6920 RVA: 0x0002B140 File Offset: 0x00029340
		public virtual double GetInteriorLogSpacingValue()
		{
			return vtkTreeRingView.vtkTreeRingView_GetInteriorLogSpacingValue_01(base.GetCppThis());
		}

		// Token: 0x06001B09 RID: 6921
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeRingView_GetInteriorRadius_02(HandleRef pThis);

		/// <summary>
		/// Set the interior radius of the tree
		/// (i.e. the size of the "hole" in the center).
		/// </summary>
		// Token: 0x06001B0A RID: 6922 RVA: 0x0002B160 File Offset: 0x00029360
		public virtual double GetInteriorRadius()
		{
			return vtkTreeRingView.vtkTreeRingView_GetInteriorRadius_02(base.GetCppThis());
		}

		// Token: 0x06001B0B RID: 6923
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeRingView_GetLayerThickness_03(HandleRef pThis);

		/// <summary>
		/// Set the thickness of each layer.
		/// </summary>
		// Token: 0x06001B0C RID: 6924 RVA: 0x0002B180 File Offset: 0x00029380
		public virtual double GetLayerThickness()
		{
			return vtkTreeRingView.vtkTreeRingView_GetLayerThickness_03(base.GetCppThis());
		}

		// Token: 0x06001B0D RID: 6925
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeRingView_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B0E RID: 6926 RVA: 0x0002B1A0 File Offset: 0x000293A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeRingView.vtkTreeRingView_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06001B0F RID: 6927
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeRingView_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B10 RID: 6928 RVA: 0x0002B1C0 File Offset: 0x000293C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeRingView.vtkTreeRingView_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06001B11 RID: 6929
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeRingView_GetRootAtCenter_06(HandleRef pThis);

		/// <summary>
		/// Sets whether the root is at the center or around the outside.
		/// </summary>
		// Token: 0x06001B12 RID: 6930 RVA: 0x0002B1DC File Offset: 0x000293DC
		public virtual bool GetRootAtCenter()
		{
			return vtkTreeRingView.vtkTreeRingView_GetRootAtCenter_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06001B13 RID: 6931
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeRingView_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B14 RID: 6932 RVA: 0x0002B204 File Offset: 0x00029404
		public override int IsA(string type)
		{
			return vtkTreeRingView.vtkTreeRingView_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06001B15 RID: 6933
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeRingView_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B16 RID: 6934 RVA: 0x0002B224 File Offset: 0x00029424
		public new static int IsTypeOf(string type)
		{
			return vtkTreeRingView.vtkTreeRingView_IsTypeOf_08(type);
		}

		// Token: 0x06001B17 RID: 6935
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeRingView_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B18 RID: 6936 RVA: 0x0002B240 File Offset: 0x00029440
		public new vtkTreeRingView NewInstance()
		{
			vtkTreeRingView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeRingView.vtkTreeRingView_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B19 RID: 6937
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_RootAtCenterOff_11(HandleRef pThis);

		/// <summary>
		/// Sets whether the root is at the center or around the outside.
		/// </summary>
		// Token: 0x06001B1A RID: 6938 RVA: 0x0002B29A File Offset: 0x0002949A
		public virtual void RootAtCenterOff()
		{
			vtkTreeRingView.vtkTreeRingView_RootAtCenterOff_11(base.GetCppThis());
		}

		// Token: 0x06001B1B RID: 6939
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_RootAtCenterOn_12(HandleRef pThis);

		/// <summary>
		/// Sets whether the root is at the center or around the outside.
		/// </summary>
		// Token: 0x06001B1C RID: 6940 RVA: 0x0002B2A9 File Offset: 0x000294A9
		public virtual void RootAtCenterOn()
		{
			vtkTreeRingView.vtkTreeRingView_RootAtCenterOn_12(base.GetCppThis());
		}

		// Token: 0x06001B1D RID: 6941
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeRingView_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B1E RID: 6942 RVA: 0x0002B2B8 File Offset: 0x000294B8
		public new static vtkTreeRingView SafeDownCast(vtkObjectBase o)
		{
			vtkTreeRingView vtkTreeRingView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeRingView.vtkTreeRingView_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeRingView = (vtkTreeRingView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeRingView.Register(null);
				}
			}
			return vtkTreeRingView;
		}

		// Token: 0x06001B1F RID: 6943
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_SetInteriorLogSpacingValue_14(HandleRef pThis, double value);

		/// <summary>
		/// Set the log spacing factor for the invisible interior tree
		/// used for routing edges of the overlaid graph.
		/// </summary>
		// Token: 0x06001B20 RID: 6944 RVA: 0x0002B337 File Offset: 0x00029537
		public virtual void SetInteriorLogSpacingValue(double value)
		{
			vtkTreeRingView.vtkTreeRingView_SetInteriorLogSpacingValue_14(base.GetCppThis(), value);
		}

		// Token: 0x06001B21 RID: 6945
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_SetInteriorRadius_15(HandleRef pThis, double rad);

		/// <summary>
		/// Set the interior radius of the tree
		/// (i.e. the size of the "hole" in the center).
		/// </summary>
		// Token: 0x06001B22 RID: 6946 RVA: 0x0002B347 File Offset: 0x00029547
		public virtual void SetInteriorRadius(double rad)
		{
			vtkTreeRingView.vtkTreeRingView_SetInteriorRadius_15(base.GetCppThis(), rad);
		}

		// Token: 0x06001B23 RID: 6947
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_SetLayerThickness_16(HandleRef pThis, double thickness);

		/// <summary>
		/// Set the thickness of each layer.
		/// </summary>
		// Token: 0x06001B24 RID: 6948 RVA: 0x0002B357 File Offset: 0x00029557
		public virtual void SetLayerThickness(double thickness)
		{
			vtkTreeRingView.vtkTreeRingView_SetLayerThickness_16(base.GetCppThis(), thickness);
		}

		// Token: 0x06001B25 RID: 6949
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_SetRootAngles_17(HandleRef pThis, double start, double end);

		/// <summary>
		/// Set the root angles for laying out the hierarchy.
		/// </summary>
		// Token: 0x06001B26 RID: 6950 RVA: 0x0002B367 File Offset: 0x00029567
		public void SetRootAngles(double start, double end)
		{
			vtkTreeRingView.vtkTreeRingView_SetRootAngles_17(base.GetCppThis(), start, end);
		}

		// Token: 0x06001B27 RID: 6951
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeRingView_SetRootAtCenter_18(HandleRef pThis, byte center);

		/// <summary>
		/// Sets whether the root is at the center or around the outside.
		/// </summary>
		// Token: 0x06001B28 RID: 6952 RVA: 0x0002B378 File Offset: 0x00029578
		public virtual void SetRootAtCenter(bool center)
		{
			vtkTreeRingView.vtkTreeRingView_SetRootAtCenter_18(base.GetCppThis(), center ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B2 RID: 1202
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeRingView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B3 RID: 1203
		public new static readonly string MRClassNameKey = "class vtkTreeRingView";
	}
}
