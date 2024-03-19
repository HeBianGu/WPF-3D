using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitSelectionLoop
	/// </summary>
	/// <remarks>
	///    implicit function for a selection loop
	///
	/// vtkImplicitSelectionLoop computes the implicit function value and
	/// function gradient for an irregular, cylinder-like object whose cross
	/// section is defined by a set of points forming a loop. The loop need
	/// not be convex nor its points coplanar. However, the loop must be
	/// non-self-intersecting when projected onto the plane defined by the
	/// accumulated cross product around the loop (i.e., the axis of the
	/// loop). (Alternatively, you can specify the normal to use.)
	///
	/// The following procedure is used to compute the implicit function
	/// value for a point x. Each point of the loop is first projected onto
	/// the plane defined by the loop normal. This forms a polygon. Then,
	/// to evaluate the implicit function value, inside/outside tests are
	/// used to determine if x is inside the polygon, and the distance to
	/// the loop boundary is computed (negative values are inside the
	/// loop).
	///
	/// One example application of this implicit function class is to draw a
	/// loop on the surface of a mesh, and use the loop to clip or extract
	/// cells from within the loop. Remember, the selection loop is "infinite"
	/// in length, you can use a plane (in boolean combination) to cap the extent
	/// of the selection loop. Another trick is to use a connectivity filter to
	/// extract the closest region to a given point (i.e., one of the points used
	/// to define the selection loop).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkImplicitBoolean vtkExtractGeometry vtkClipPolyData
	/// vtkConnectivityFilter vtkPolyDataConnectivityFilter
	/// </seealso>
	// Token: 0x02000A6A RID: 2666
	public class vtkImplicitSelectionLoop : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BE89 RID: 114313 RVA: 0x00271881 File Offset: 0x0026FA81
		static vtkImplicitSelectionLoop()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitSelectionLoop.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitSelectionLoop"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE8A RID: 114314 RVA: 0x002718A9 File Offset: 0x0026FAA9
		public vtkImplicitSelectionLoop(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BE8B RID: 114315
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSelectionLoop_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with no initial loop.
		/// </summary>
		// Token: 0x0601BE8C RID: 114316 RVA: 0x002718B8 File Offset: 0x0026FAB8
		public new static vtkImplicitSelectionLoop New()
		{
			vtkImplicitSelectionLoop result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with no initial loop.
		/// </summary>
		// Token: 0x0601BE8D RID: 114317 RVA: 0x0027190C File Offset: 0x0026FB0C
		public vtkImplicitSelectionLoop() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE8E RID: 114318 RVA: 0x00271950 File Offset: 0x0026FB50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BE8F RID: 114319
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_AutomaticNormalGenerationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic normal generation. By default, the normal is
		/// computed from the accumulated cross product of the edges. You can also
		/// specify the normal to use.
		/// </summary>
		// Token: 0x0601BE90 RID: 114320 RVA: 0x0027195B File Offset: 0x0026FB5B
		public virtual void AutomaticNormalGenerationOff()
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_AutomaticNormalGenerationOff_01(base.GetCppThis());
		}

		// Token: 0x0601BE91 RID: 114321
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_AutomaticNormalGenerationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic normal generation. By default, the normal is
		/// computed from the accumulated cross product of the edges. You can also
		/// specify the normal to use.
		/// </summary>
		// Token: 0x0601BE92 RID: 114322 RVA: 0x0027196A File Offset: 0x0026FB6A
		public virtual void AutomaticNormalGenerationOn()
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_AutomaticNormalGenerationOn_02(base.GetCppThis());
		}

		// Token: 0x0601BE93 RID: 114323
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitSelectionLoop_EvaluateFunction_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate selection loop returning a signed distance.
		/// </summary>
		// Token: 0x0601BE94 RID: 114324 RVA: 0x0027197C File Offset: 0x0026FB7C
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_EvaluateFunction_03(base.GetCppThis(), x);
		}

		// Token: 0x0601BE95 RID: 114325
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate selection loop returning the gradient.
		/// </summary>
		// Token: 0x0601BE96 RID: 114326 RVA: 0x0027199C File Offset: 0x0026FB9C
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_EvaluateGradient_04(base.GetCppThis(), x, n);
		}

		// Token: 0x0601BE97 RID: 114327
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitSelectionLoop_GetAutomaticNormalGeneration_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic normal generation. By default, the normal is
		/// computed from the accumulated cross product of the edges. You can also
		/// specify the normal to use.
		/// </summary>
		// Token: 0x0601BE98 RID: 114328 RVA: 0x002719B0 File Offset: 0x0026FBB0
		public virtual int GetAutomaticNormalGeneration()
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetAutomaticNormalGeneration_05(base.GetCppThis());
		}

		// Token: 0x0601BE99 RID: 114329
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSelectionLoop_GetLoop_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the array of point coordinates defining the loop. There must
		/// be at least three points used to define a loop.
		/// </summary>
		// Token: 0x0601BE9A RID: 114330 RVA: 0x002719D0 File Offset: 0x0026FBD0
		public virtual vtkPoints GetLoop()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetLoop_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601BE9B RID: 114331
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitSelectionLoop_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Overload GetMTime() because we depend on the Loop
		/// </summary>
		// Token: 0x0601BE9C RID: 114332 RVA: 0x00271A40 File Offset: 0x0026FC40
		public override ulong GetMTime()
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x0601BE9D RID: 114333
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSelectionLoop_GetNormal_08(HandleRef pThis);

		/// <summary>
		/// Set / get the normal used to determine whether a point is inside or outside
		/// the selection loop.
		/// </summary>
		// Token: 0x0601BE9E RID: 114334 RVA: 0x00271A60 File Offset: 0x0026FC60
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetNormal_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BE9F RID: 114335
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_GetNormal_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the normal used to determine whether a point is inside or outside
		/// the selection loop.
		/// </summary>
		// Token: 0x0601BEA0 RID: 114336 RVA: 0x00271AA8 File Offset: 0x0026FCA8
		public virtual void GetNormal(IntPtr data)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetNormal_09(base.GetCppThis(), data);
		}

		// Token: 0x0601BEA1 RID: 114337
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for printing and type information.
		/// </summary>
		// Token: 0x0601BEA2 RID: 114338 RVA: 0x00271AB8 File Offset: 0x0026FCB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601BEA3 RID: 114339
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for printing and type information.
		/// </summary>
		// Token: 0x0601BEA4 RID: 114340 RVA: 0x00271AD8 File Offset: 0x0026FCD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601BEA5 RID: 114341
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitSelectionLoop_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for printing and type information.
		/// </summary>
		// Token: 0x0601BEA6 RID: 114342 RVA: 0x00271AF4 File Offset: 0x0026FCF4
		public override int IsA(string type)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601BEA7 RID: 114343
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitSelectionLoop_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for printing and type information.
		/// </summary>
		// Token: 0x0601BEA8 RID: 114344 RVA: 0x00271B14 File Offset: 0x0026FD14
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_IsTypeOf_13(type);
		}

		// Token: 0x0601BEA9 RID: 114345
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSelectionLoop_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for printing and type information.
		/// </summary>
		// Token: 0x0601BEAA RID: 114346 RVA: 0x00271B30 File Offset: 0x0026FD30
		public new vtkImplicitSelectionLoop NewInstance()
		{
			vtkImplicitSelectionLoop result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BEAB RID: 114347
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSelectionLoop_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for printing and type information.
		/// </summary>
		// Token: 0x0601BEAC RID: 114348 RVA: 0x00271B8C File Offset: 0x0026FD8C
		public new static vtkImplicitSelectionLoop SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitSelectionLoop vtkImplicitSelectionLoop = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitSelectionLoop = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitSelectionLoop.Register(null);
				}
			}
			return vtkImplicitSelectionLoop;
		}

		// Token: 0x0601BEAD RID: 114349
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_SetAutomaticNormalGeneration_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic normal generation. By default, the normal is
		/// computed from the accumulated cross product of the edges. You can also
		/// specify the normal to use.
		/// </summary>
		// Token: 0x0601BEAE RID: 114350 RVA: 0x00271C0B File Offset: 0x0026FE0B
		public virtual void SetAutomaticNormalGeneration(int _arg)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetAutomaticNormalGeneration_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BEAF RID: 114351
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_SetLoop_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the array of point coordinates defining the loop. There must
		/// be at least three points used to define a loop.
		/// </summary>
		// Token: 0x0601BEB0 RID: 114352 RVA: 0x00271C1C File Offset: 0x0026FE1C
		public virtual void SetLoop(vtkPoints arg0)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetLoop_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BEB1 RID: 114353
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_SetNormal_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set / get the normal used to determine whether a point is inside or outside
		/// the selection loop.
		/// </summary>
		// Token: 0x0601BEB2 RID: 114354 RVA: 0x00271C4B File Offset: 0x0026FE4B
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetNormal_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601BEB3 RID: 114355
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSelectionLoop_SetNormal_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the normal used to determine whether a point is inside or outside
		/// the selection loop.
		/// </summary>
		// Token: 0x0601BEB4 RID: 114356 RVA: 0x00271C5D File Offset: 0x0026FE5D
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetNormal_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DCB RID: 7627
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitSelectionLoop";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DCC RID: 7628
		public new static readonly string MRClassNameKey = "class vtkImplicitSelectionLoop";
	}
}
