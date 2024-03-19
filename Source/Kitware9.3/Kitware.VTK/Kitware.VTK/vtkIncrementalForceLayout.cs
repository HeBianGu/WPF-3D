using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIncrementalForceLayout
	/// </summary>
	/// <remarks>
	///    incremental force-directed layout.
	///
	///
	/// Performs an incremental force-directed layout of a graph. Set the graph
	/// then iteratively execute UpdatePositions() to update the vertex positions.
	/// Note that this directly modifies the vertex locations in the graph.
	///
	/// This layout is modeled after D3's force layout described at
	/// https://github.com/mbostock/d3/wiki/Force-Layout
	/// </remarks>
	// Token: 0x02000292 RID: 658
	public class vtkIncrementalForceLayout : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007718 RID: 30488 RVA: 0x000ABD09 File Offset: 0x000A9F09
		static vtkIncrementalForceLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalForceLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalForceLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007719 RID: 30489 RVA: 0x000ABD31 File Offset: 0x000A9F31
		public vtkIncrementalForceLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600771A RID: 30490
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalForceLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600771B RID: 30491 RVA: 0x000ABD40 File Offset: 0x000A9F40
		public new static vtkIncrementalForceLayout New()
		{
			vtkIncrementalForceLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalForceLayout.vtkIncrementalForceLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600771C RID: 30492 RVA: 0x000ABD94 File Offset: 0x000A9F94
		public vtkIncrementalForceLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIncrementalForceLayout.vtkIncrementalForceLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600771D RID: 30493 RVA: 0x000ABDD8 File Offset: 0x000A9FD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600771E RID: 30494
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetAlpha_01(HandleRef pThis);

		/// <summary>
		/// Set the level of activity in the simulation. Default is 0.1.
		/// </summary>
		// Token: 0x0600771F RID: 30495 RVA: 0x000ABDE4 File Offset: 0x000A9FE4
		public virtual float GetAlpha()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetAlpha_01(base.GetCppThis());
		}

		// Token: 0x06007720 RID: 30496
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetCharge_02(HandleRef pThis);

		/// <summary>
		/// Set the charge of each vertex. Higher negative values will repel vertices
		/// from each other more strongly. Default is -30.
		/// </summary>
		// Token: 0x06007721 RID: 30497 RVA: 0x000ABE04 File Offset: 0x000AA004
		public virtual float GetCharge()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetCharge_02(base.GetCppThis());
		}

		// Token: 0x06007722 RID: 30498
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetDistance_03(HandleRef pThis);

		/// <summary>
		/// Set the resting distance of each link in scene units, which is equal to
		/// pixels when there is no scene scaling. Default is 20.
		/// </summary>
		// Token: 0x06007723 RID: 30499 RVA: 0x000ABE24 File Offset: 0x000AA024
		public virtual float GetDistance()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetDistance_03(base.GetCppThis());
		}

		// Token: 0x06007724 RID: 30500
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalForceLayout_GetFixed_04(HandleRef pThis);

		/// <summary>
		/// Set the id of the vertex that will not move during the simulation.
		/// Set to -1 to allow all the vertices to move.
		/// </summary>
		// Token: 0x06007725 RID: 30501 RVA: 0x000ABE44 File Offset: 0x000AA044
		public virtual long GetFixed()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetFixed_04(base.GetCppThis());
		}

		// Token: 0x06007726 RID: 30502
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetFriction_05(HandleRef pThis);

		/// <summary>
		/// Set the multiplier for scaling down velocity in the simulation, where values closer to 1
		/// are more frictionless. Default is 0.95.
		/// </summary>
		// Token: 0x06007727 RID: 30503 RVA: 0x000ABE64 File Offset: 0x000AA064
		public virtual float GetFriction()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetFriction_05(base.GetCppThis());
		}

		// Token: 0x06007728 RID: 30504
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalForceLayout_GetGraph_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the graph to be positioned.
		/// </summary>
		// Token: 0x06007729 RID: 30505 RVA: 0x000ABE84 File Offset: 0x000AA084
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetGraph_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0600772A RID: 30506
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetGravity_07(HandleRef pThis);

		/// <summary>
		/// Set the amount of gravitational pull toward the gravity point.
		/// Default is 0.01.
		/// </summary>
		// Token: 0x0600772B RID: 30507 RVA: 0x000ABEF4 File Offset: 0x000AA0F4
		public virtual float GetGravity()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetGravity_07(base.GetCppThis());
		}

		// Token: 0x0600772C RID: 30508
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalForceLayout_GetGravityPoint_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the gravity point where all vertices will migrate. Generally this
		/// should be set to the location in the center of the scene.
		/// Default location is (200, 200).
		/// </summary>
		// Token: 0x0600772D RID: 30509 RVA: 0x000ABF14 File Offset: 0x000AA114
		public virtual vtkVector2f GetGravityPoint()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetGravityPoint_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600772E RID: 30510
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalForceLayout_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600772F RID: 30511 RVA: 0x000ABF70 File Offset: 0x000AA170
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06007730 RID: 30512
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalForceLayout_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007731 RID: 30513 RVA: 0x000ABF90 File Offset: 0x000AA190
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06007732 RID: 30514
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetStrength_11(HandleRef pThis);

		/// <summary>
		/// Set the rigitity of links in the simulation. Default is 2.
		/// </summary>
		// Token: 0x06007733 RID: 30515 RVA: 0x000ABFAC File Offset: 0x000AA1AC
		public virtual float GetStrength()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetStrength_11(base.GetCppThis());
		}

		// Token: 0x06007734 RID: 30516
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkIncrementalForceLayout_GetTheta_12(HandleRef pThis);

		/// <summary>
		/// Set the Barnes-Hut threshold for the simulation. Higher values
		/// will speed the simulation at the expense of some accuracy.
		/// Default is 0.8.
		/// </summary>
		// Token: 0x06007735 RID: 30517 RVA: 0x000ABFCC File Offset: 0x000AA1CC
		public virtual float GetTheta()
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_GetTheta_12(base.GetCppThis());
		}

		// Token: 0x06007736 RID: 30518
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalForceLayout_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007737 RID: 30519 RVA: 0x000ABFEC File Offset: 0x000AA1EC
		public override int IsA(string type)
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06007738 RID: 30520
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalForceLayout_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007739 RID: 30521 RVA: 0x000AC00C File Offset: 0x000AA20C
		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalForceLayout.vtkIncrementalForceLayout_IsTypeOf_14(type);
		}

		// Token: 0x0600773A RID: 30522
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalForceLayout_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600773B RID: 30523 RVA: 0x000AC028 File Offset: 0x000AA228
		public new vtkIncrementalForceLayout NewInstance()
		{
			vtkIncrementalForceLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalForceLayout.vtkIncrementalForceLayout_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600773C RID: 30524
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalForceLayout_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600773D RID: 30525 RVA: 0x000AC084 File Offset: 0x000AA284
		public new static vtkIncrementalForceLayout SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalForceLayout vtkIncrementalForceLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalForceLayout.vtkIncrementalForceLayout_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalForceLayout = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalForceLayout.Register(null);
				}
			}
			return vtkIncrementalForceLayout;
		}

		// Token: 0x0600773E RID: 30526
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetAlpha_18(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the level of activity in the simulation. Default is 0.1.
		/// </summary>
		// Token: 0x0600773F RID: 30527 RVA: 0x000AC103 File Offset: 0x000AA303
		public virtual void SetAlpha(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetAlpha_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06007740 RID: 30528
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetCharge_19(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the charge of each vertex. Higher negative values will repel vertices
		/// from each other more strongly. Default is -30.
		/// </summary>
		// Token: 0x06007741 RID: 30529 RVA: 0x000AC113 File Offset: 0x000AA313
		public virtual void SetCharge(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetCharge_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06007742 RID: 30530
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetDistance_20(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the resting distance of each link in scene units, which is equal to
		/// pixels when there is no scene scaling. Default is 20.
		/// </summary>
		// Token: 0x06007743 RID: 30531 RVA: 0x000AC123 File Offset: 0x000AA323
		public virtual void SetDistance(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetDistance_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06007744 RID: 30532
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetFixed_21(HandleRef pThis, long arg0);

		/// <summary>
		/// Set the id of the vertex that will not move during the simulation.
		/// Set to -1 to allow all the vertices to move.
		/// </summary>
		// Token: 0x06007745 RID: 30533 RVA: 0x000AC133 File Offset: 0x000AA333
		public virtual void SetFixed(long arg0)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetFixed_21(base.GetCppThis(), arg0);
		}

		// Token: 0x06007746 RID: 30534
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetFriction_22(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the multiplier for scaling down velocity in the simulation, where values closer to 1
		/// are more frictionless. Default is 0.95.
		/// </summary>
		// Token: 0x06007747 RID: 30535 RVA: 0x000AC143 File Offset: 0x000AA343
		public virtual void SetFriction(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetFriction_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06007748 RID: 30536
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetGraph_23(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Set the graph to be positioned.
		/// </summary>
		// Token: 0x06007749 RID: 30537 RVA: 0x000AC154 File Offset: 0x000AA354
		public virtual void SetGraph(vtkGraph g)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetGraph_23(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x0600774A RID: 30538
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetGravity_24(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the amount of gravitational pull toward the gravity point.
		/// Default is 0.01.
		/// </summary>
		// Token: 0x0600774B RID: 30539 RVA: 0x000AC183 File Offset: 0x000AA383
		public virtual void SetGravity(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetGravity_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600774C RID: 30540
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetGravityPoint_25(HandleRef pThis, HandleRef point);

		/// <summary>
		/// Set the gravity point where all vertices will migrate. Generally this
		/// should be set to the location in the center of the scene.
		/// Default location is (200, 200).
		/// </summary>
		// Token: 0x0600774D RID: 30541 RVA: 0x000AC194 File Offset: 0x000AA394
		public virtual void SetGravityPoint(vtkVector2f point)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetGravityPoint_25(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis());
		}

		// Token: 0x0600774E RID: 30542
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetStrength_26(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the rigitity of links in the simulation. Default is 2.
		/// </summary>
		// Token: 0x0600774F RID: 30543 RVA: 0x000AC1C3 File Offset: 0x000AA3C3
		public virtual void SetStrength(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetStrength_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06007750 RID: 30544
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_SetTheta_27(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the Barnes-Hut threshold for the simulation. Higher values
		/// will speed the simulation at the expense of some accuracy.
		/// Default is 0.8.
		/// </summary>
		// Token: 0x06007751 RID: 30545 RVA: 0x000AC1D3 File Offset: 0x000AA3D3
		public virtual void SetTheta(float _arg)
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_SetTheta_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06007752 RID: 30546
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalForceLayout_UpdatePositions_28(HandleRef pThis);

		/// <summary>
		/// Perform one iteration of the force-directed layout.
		/// </summary>
		// Token: 0x06007753 RID: 30547 RVA: 0x000AC1E3 File Offset: 0x000AA3E3
		public void UpdatePositions()
		{
			vtkIncrementalForceLayout.vtkIncrementalForceLayout_UpdatePositions_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A32 RID: 2610
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalForceLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A33 RID: 2611
		public new static readonly string MRClassNameKey = "class vtkIncrementalForceLayout";
	}
}
