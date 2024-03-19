using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAdaptiveDataSetSurfaceFilter
	/// </summary>
	/// <remarks>
	///    Adaptively extract dataset surface
	///
	/// vtkAdaptiveDataSetSurfaceFilter uses view and dataset properties to
	/// create the outside surface mesh with the minimum minimorum of facets
	/// @warning
	/// Only implemented currently for 2-dimensional vtkHyperTreeGrid objects
	/// </remarks>
	/// <seealso>
	///
	/// vtkHyperTreeGrid vtkDataSetSurfaceFilter
	/// @par Thanks:
	/// This class was written by Guenole Harel and Jacques-Bernard Lekien, 2014
	/// This class was rewritten by Philippe Pebay, 2016
	/// This class was modified by Rogeli Grima, 2016
	/// This work was supported by Commissariat a l'Energie Atomique (CEA/DIF)
	/// CEA, DAM, DIF, F-91297 Arpajon, France.
	/// </seealso>
	// Token: 0x02000600 RID: 1536
	public class vtkAdaptiveDataSetSurfaceFilter : vtkGeometryFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010B05 RID: 68357 RVA: 0x00174719 File Offset: 0x00172919
		static vtkAdaptiveDataSetSurfaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdaptiveDataSetSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdaptiveDataSetSurfaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010B06 RID: 68358 RVA: 0x00174741 File Offset: 0x00172941
		public vtkAdaptiveDataSetSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010B07 RID: 68359
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B08 RID: 68360 RVA: 0x00174750 File Offset: 0x00172950
		public new static vtkAdaptiveDataSetSurfaceFilter New()
		{
			vtkAdaptiveDataSetSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdaptiveDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B09 RID: 68361 RVA: 0x001747A4 File Offset: 0x001729A4
		public vtkAdaptiveDataSetSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010B0A RID: 68362 RVA: 0x001747E8 File Offset: 0x001729E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010B0B RID: 68363
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAdaptiveDataSetSurfaceFilter_GetBBSelection_01(HandleRef pThis);

		/// <summary>
		/// Set/Get for active the bounding box selection viewport (default false)
		/// JB C'est un facteur supplementaire d'acceleration possible
		/// JB uniquement si l'on ne peut faire de rotation dans la vue.
		/// </summary>
		// Token: 0x06010B0C RID: 68364 RVA: 0x001747F4 File Offset: 0x001729F4
		public virtual bool GetBBSelection()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetBBSelection_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06010B0D RID: 68365
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAdaptiveDataSetSurfaceFilter_GetCircleSelection_02(HandleRef pThis);

		/// <summary>
		/// Set/Get for active the circle selection viewport (default true)
		/// </summary>
		// Token: 0x06010B0E RID: 68366 RVA: 0x0017481C File Offset: 0x00172A1C
		public virtual bool GetCircleSelection()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetCircleSelection_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06010B0F RID: 68367
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveDataSetSurfaceFilter_GetDynamicDecimateLevelMax_03(HandleRef pThis);

		/// <summary>
		/// JB Set/Get reduit de autant le niveau max de profondeur, calcule
		/// JB dynamiquement a parcourir dans la
		/// JB representation HTG. (defaut 0)
		/// </summary>
		// Token: 0x06010B10 RID: 68368 RVA: 0x00174844 File Offset: 0x00172A44
		public virtual int GetDynamicDecimateLevelMax()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetDynamicDecimateLevelMax_03(base.GetCppThis());
		}

		// Token: 0x06010B11 RID: 68369
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveDataSetSurfaceFilter_GetFixedLevelMax_04(HandleRef pThis);

		/// <summary>
		/// Set/Get for forced a fixed the level max (lost dynamicity) (default -1)
		/// </summary>
		// Token: 0x06010B12 RID: 68370 RVA: 0x00174864 File Offset: 0x00172A64
		public virtual int GetFixedLevelMax()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetFixedLevelMax_04(base.GetCppThis());
		}

		// Token: 0x06010B13 RID: 68371
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAdaptiveDataSetSurfaceFilter_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Get the mtime of this object.
		/// </summary>
		// Token: 0x06010B14 RID: 68372 RVA: 0x00174884 File Offset: 0x00172A84
		public override ulong GetMTime()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06010B15 RID: 68373
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B16 RID: 68374 RVA: 0x001748A4 File Offset: 0x00172AA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06010B17 RID: 68375
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B18 RID: 68376 RVA: 0x001748C4 File Offset: 0x00172AC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06010B19 RID: 68377
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_GetRenderer_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the renderer attached to this adaptive surface extractor
		/// </summary>
		// Token: 0x06010B1A RID: 68378 RVA: 0x001748E0 File Offset: 0x00172AE0
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetRenderer_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06010B1B RID: 68379
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveDataSetSurfaceFilter_GetScale_09(HandleRef pThis);

		/// <summary>
		/// JB Set/Get the scale factor influence le calcul de l'adaptive view.
		/// JB Pour un raffinement de 2, donner Scale=2*X revient a faire un
		/// JB appel a DynamicDecimateLevelMax avec la valeur X. (defaut 1)
		/// </summary>
		// Token: 0x06010B1C RID: 68380 RVA: 0x00174950 File Offset: 0x00172B50
		public virtual double GetScale()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetScale_09(base.GetCppThis());
		}

		// Token: 0x06010B1D RID: 68381
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAdaptiveDataSetSurfaceFilter_GetViewPointDepend_10(HandleRef pThis);

		/// <summary>
		/// JB Activation de la dependance au point de vue. Par defaut a True.
		/// </summary>
		// Token: 0x06010B1E RID: 68382 RVA: 0x00174970 File Offset: 0x00172B70
		public virtual bool GetViewPointDepend()
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_GetViewPointDepend_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06010B1F RID: 68383
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveDataSetSurfaceFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B20 RID: 68384 RVA: 0x00174998 File Offset: 0x00172B98
		public override int IsA(string type)
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06010B21 RID: 68385
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveDataSetSurfaceFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B22 RID: 68386 RVA: 0x001749B8 File Offset: 0x00172BB8
		public new static int IsTypeOf(string type)
		{
			return vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_IsTypeOf_12(type);
		}

		// Token: 0x06010B23 RID: 68387
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B24 RID: 68388 RVA: 0x001749D4 File Offset: 0x00172BD4
		public new vtkAdaptiveDataSetSurfaceFilter NewInstance()
		{
			vtkAdaptiveDataSetSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdaptiveDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010B25 RID: 68389
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveDataSetSurfaceFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B26 RID: 68390 RVA: 0x00174A30 File Offset: 0x00172C30
		public new static vtkAdaptiveDataSetSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAdaptiveDataSetSurfaceFilter vtkAdaptiveDataSetSurfaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdaptiveDataSetSurfaceFilter = (vtkAdaptiveDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdaptiveDataSetSurfaceFilter.Register(null);
				}
			}
			return vtkAdaptiveDataSetSurfaceFilter;
		}

		// Token: 0x06010B27 RID: 68391
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetBBSelection_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get for active the bounding box selection viewport (default false)
		/// JB C'est un facteur supplementaire d'acceleration possible
		/// JB uniquement si l'on ne peut faire de rotation dans la vue.
		/// </summary>
		// Token: 0x06010B28 RID: 68392 RVA: 0x00174AAF File Offset: 0x00172CAF
		public virtual void SetBBSelection(bool _arg)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetBBSelection_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010B29 RID: 68393
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetCircleSelection_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get for active the circle selection viewport (default true)
		/// </summary>
		// Token: 0x06010B2A RID: 68394 RVA: 0x00174AC7 File Offset: 0x00172CC7
		public virtual void SetCircleSelection(bool _arg)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetCircleSelection_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010B2B RID: 68395
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetDynamicDecimateLevelMax_18(HandleRef pThis, int _arg);

		/// <summary>
		/// JB Set/Get reduit de autant le niveau max de profondeur, calcule
		/// JB dynamiquement a parcourir dans la
		/// JB representation HTG. (defaut 0)
		/// </summary>
		// Token: 0x06010B2C RID: 68396 RVA: 0x00174ADF File Offset: 0x00172CDF
		public virtual void SetDynamicDecimateLevelMax(int _arg)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetDynamicDecimateLevelMax_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06010B2D RID: 68397
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetFixedLevelMax_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get for forced a fixed the level max (lost dynamicity) (default -1)
		/// </summary>
		// Token: 0x06010B2E RID: 68398 RVA: 0x00174AEF File Offset: 0x00172CEF
		public virtual void SetFixedLevelMax(int _arg)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetFixedLevelMax_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06010B2F RID: 68399
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetRenderer_20(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Set/Get the renderer attached to this adaptive surface extractor
		/// </summary>
		// Token: 0x06010B30 RID: 68400 RVA: 0x00174B00 File Offset: 0x00172D00
		public void SetRenderer(vtkRenderer ren)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetRenderer_20(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06010B31 RID: 68401
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetScale_21(HandleRef pThis, double _arg);

		/// <summary>
		/// JB Set/Get the scale factor influence le calcul de l'adaptive view.
		/// JB Pour un raffinement de 2, donner Scale=2*X revient a faire un
		/// JB appel a DynamicDecimateLevelMax avec la valeur X. (defaut 1)
		/// </summary>
		// Token: 0x06010B32 RID: 68402 RVA: 0x00174B2F File Offset: 0x00172D2F
		public virtual void SetScale(double _arg)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetScale_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06010B33 RID: 68403
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveDataSetSurfaceFilter_SetViewPointDepend_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// JB Activation de la dependance au point de vue. Par defaut a True.
		/// </summary>
		// Token: 0x06010B34 RID: 68404 RVA: 0x00174B3F File Offset: 0x00172D3F
		public virtual void SetViewPointDepend(bool _arg)
		{
			vtkAdaptiveDataSetSurfaceFilter.vtkAdaptiveDataSetSurfaceFilter_SetViewPointDepend_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001356 RID: 4950
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdaptiveDataSetSurfaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001357 RID: 4951
		public new static readonly string MRClassNameKey = "class vtkAdaptiveDataSetSurfaceFilter";
	}
}
