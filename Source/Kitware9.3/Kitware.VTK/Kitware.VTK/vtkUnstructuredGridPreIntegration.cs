using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridPreIntegration
	/// </summary>
	/// <remarks>
	///    performs ray integration with pre-integration tables.
	///
	///
	///
	/// vtkUnstructuredGridPreIntegration performs ray integration by looking
	/// into a precomputed table.  The result should be equivalent to that
	/// computed by vtkUnstructuredGridLinearRayIntegrator and
	/// vtkUnstructuredGridPartialPreIntegration, but faster than either one.
	/// The pre-integration algorithm was first introduced by Roettger, Kraus,
	/// and Ertl in "Hardware-Accelerated Volume And Isosurface Rendering Based
	/// On Cell-Projection."
	///
	/// Due to table size limitations, a table can only be indexed by
	/// independent scalars.  Thus, dependent scalars are not supported.
	///
	/// </remarks>
	// Token: 0x020003A8 RID: 936
	public class vtkUnstructuredGridPreIntegration : vtkUnstructuredGridVolumeRayIntegrator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A9E7 RID: 43495 RVA: 0x000F18B7 File Offset: 0x000EFAB7
		static vtkUnstructuredGridPreIntegration()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridPreIntegration.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridPreIntegration"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A9E8 RID: 43496 RVA: 0x000F18DF File Offset: 0x000EFADF
		public vtkUnstructuredGridPreIntegration(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A9E9 RID: 43497
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9EA RID: 43498 RVA: 0x000F18F0 File Offset: 0x000EFAF0
		public new static vtkUnstructuredGridPreIntegration New()
		{
			vtkUnstructuredGridPreIntegration result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9EB RID: 43499 RVA: 0x000F1944 File Offset: 0x000EFB44
		public vtkUnstructuredGridPreIntegration() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A9EC RID: 43500 RVA: 0x000F1988 File Offset: 0x000EFB88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A9ED RID: 43501
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPreIntegration_GetIncrementalPreIntegration_01(HandleRef pThis);

		/// <summary>
		/// Get/set whether to use incremental pre-integration (by default it's
		/// on).  Incremental pre-integration is much faster but can introduce
		/// error due to numerical imprecision.  Under most circumstances, the
		/// error is not noticeable.
		/// </summary>
		// Token: 0x0600A9EE RID: 43502 RVA: 0x000F1994 File Offset: 0x000EFB94
		public virtual int GetIncrementalPreIntegration()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIncrementalPreIntegration_01(base.GetCppThis());
		}

		// Token: 0x0600A9EF RID: 43503
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetIndexedTableEntry_02(HandleRef pThis, int scalar_front_index, int scalar_back_index, int length_index, int component);

		/// <summary>
		/// Like GetTableEntry, except the inputs are scaled indices into the table
		/// rather than than the actual scalar and length values.  Use GetTableEntry
		/// unless you are really sure you know what you are doing.
		/// </summary>
		// Token: 0x0600A9F0 RID: 43504 RVA: 0x000F19B4 File Offset: 0x000EFBB4
		public IntPtr GetIndexedTableEntry(int scalar_front_index, int scalar_back_index, int length_index, int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIndexedTableEntry_02(base.GetCppThis(), scalar_front_index, scalar_back_index, length_index, component);
		}

		// Token: 0x0600A9F1 RID: 43505
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthResolution_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the integration table built.
		/// </summary>
		// Token: 0x0600A9F2 RID: 43506 RVA: 0x000F19D8 File Offset: 0x000EFBD8
		public virtual int GetIntegrationTableLengthResolution()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthResolution_03(base.GetCppThis());
		}

		// Token: 0x0600A9F3 RID: 43507
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthScale_04(HandleRef pThis);

		/// <summary>
		/// Get how an integration table is indexed.
		/// </summary>
		// Token: 0x0600A9F4 RID: 43508 RVA: 0x000F19F8 File Offset: 0x000EFBF8
		public virtual double GetIntegrationTableLengthScale()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthScale_04(base.GetCppThis());
		}

		// Token: 0x0600A9F5 RID: 43509
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarResolution_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the integration table built.
		/// </summary>
		// Token: 0x0600A9F6 RID: 43510 RVA: 0x000F1A18 File Offset: 0x000EFC18
		public virtual int GetIntegrationTableScalarResolution()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarResolution_05(base.GetCppThis());
		}

		// Token: 0x0600A9F7 RID: 43511
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarScale_06(HandleRef pThis, int component);

		/// <summary>
		/// Get how an integration table is indexed.
		/// </summary>
		// Token: 0x0600A9F8 RID: 43512 RVA: 0x000F1A38 File Offset: 0x000EFC38
		public virtual double GetIntegrationTableScalarScale(int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarScale_06(base.GetCppThis(), component);
		}

		// Token: 0x0600A9F9 RID: 43513
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarShift_07(HandleRef pThis, int component);

		/// <summary>
		/// Get how an integration table is indexed.
		/// </summary>
		// Token: 0x0600A9FA RID: 43514 RVA: 0x000F1A58 File Offset: 0x000EFC58
		public virtual double GetIntegrationTableScalarShift(int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarShift_07(base.GetCppThis(), component);
		}

		// Token: 0x0600A9FB RID: 43515
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetIntegrator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The class used to fill the pre integration table.  By default, a
		/// vtkUnstructuredGridPartialPreIntegration is built.
		/// </summary>
		// Token: 0x0600A9FC RID: 43516 RVA: 0x000F1A78 File Offset: 0x000EFC78
		public virtual vtkUnstructuredGridVolumeRayIntegrator GetIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrator_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayIntegrator = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayIntegrator;
		}

		// Token: 0x0600A9FD RID: 43517
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9FE RID: 43518 RVA: 0x000F1AE8 File Offset: 0x000EFCE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600A9FF RID: 43519
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA00 RID: 43520 RVA: 0x000F1B08 File Offset: 0x000EFD08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600AA01 RID: 43521
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetPreIntegrationTable_11(HandleRef pThis, int component);

		/// <summary>
		/// Get the partial pre-integration table for the given scalar component.
		/// The tables are built when Initialize is called.  A segment of length d
		/// with a front scalar of sf and a back scalar of sb is referenced in the
		/// resulting table as 4 * ((l * \c IntegrationTableLengthScale) * \c
		/// IntegrationTableScalarResolution * \c IntegrationTableScalarResolution
		/// + (sb * \c IntegrationTableScalarScale + \c
		/// IntegrationTableScalarShift) * \c IntegrationTableScalarResolution
		/// + (sf * \c IntegrationTableScalarScale + \c
		/// IntegrationTableScalarShift)).
		/// </summary>
		// Token: 0x0600AA02 RID: 43522 RVA: 0x000F1B24 File Offset: 0x000EFD24
		public virtual IntPtr GetPreIntegrationTable(int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetPreIntegrationTable_11(base.GetCppThis(), component);
		}

		// Token: 0x0600AA03 RID: 43523
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetTableEntry_12(HandleRef pThis, double scalar_front, double scalar_back, double length, int component);

		/// <summary>
		/// Get an entry (RGBA) in one of the pre-integration tables.  The tables
		/// are built when Initialize is called.
		/// </summary>
		// Token: 0x0600AA04 RID: 43524 RVA: 0x000F1B44 File Offset: 0x000EFD44
		public IntPtr GetTableEntry(double scalar_front, double scalar_back, double length, int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetTableEntry_12(base.GetCppThis(), scalar_front, scalar_back, length, component);
		}

		// Token: 0x0600AA05 RID: 43525
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOff_13(HandleRef pThis);

		/// <summary>
		/// Get/set whether to use incremental pre-integration (by default it's
		/// on).  Incremental pre-integration is much faster but can introduce
		/// error due to numerical imprecision.  Under most circumstances, the
		/// error is not noticeable.
		/// </summary>
		// Token: 0x0600AA06 RID: 43526 RVA: 0x000F1B68 File Offset: 0x000EFD68
		public virtual void IncrementalPreIntegrationOff()
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOff_13(base.GetCppThis());
		}

		// Token: 0x0600AA07 RID: 43527
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOn_14(HandleRef pThis);

		/// <summary>
		/// Get/set whether to use incremental pre-integration (by default it's
		/// on).  Incremental pre-integration is much faster but can introduce
		/// error due to numerical imprecision.  Under most circumstances, the
		/// error is not noticeable.
		/// </summary>
		// Token: 0x0600AA08 RID: 43528 RVA: 0x000F1B77 File Offset: 0x000EFD77
		public virtual void IncrementalPreIntegrationOn()
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOn_14(base.GetCppThis());
		}

		// Token: 0x0600AA09 RID: 43529
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_Initialize_15(HandleRef pThis, HandleRef volume, HandleRef scalars);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA0A RID: 43530 RVA: 0x000F1B88 File Offset: 0x000EFD88
		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_Initialize_15(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0600AA0B RID: 43531
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_Integrate_16(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA0C RID: 43532 RVA: 0x000F1BCC File Offset: 0x000EFDCC
		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_Integrate_16(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		// Token: 0x0600AA0D RID: 43533
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPreIntegration_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA0E RID: 43534 RVA: 0x000F1C28 File Offset: 0x000EFE28
		public override int IsA(string type)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600AA0F RID: 43535
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPreIntegration_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA10 RID: 43536 RVA: 0x000F1C48 File Offset: 0x000EFE48
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IsTypeOf_18(type);
		}

		// Token: 0x0600AA11 RID: 43537
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA12 RID: 43538 RVA: 0x000F1C64 File Offset: 0x000EFE64
		public new vtkUnstructuredGridPreIntegration NewInstance()
		{
			vtkUnstructuredGridPreIntegration result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AA13 RID: 43539
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA14 RID: 43540 RVA: 0x000F1CC0 File Offset: 0x000EFEC0
		public new static vtkUnstructuredGridPreIntegration SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridPreIntegration vtkUnstructuredGridPreIntegration = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridPreIntegration = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridPreIntegration.Register(null);
				}
			}
			return vtkUnstructuredGridPreIntegration;
		}

		// Token: 0x0600AA15 RID: 43541
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIncrementalPreIntegration_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/set whether to use incremental pre-integration (by default it's
		/// on).  Incremental pre-integration is much faster but can introduce
		/// error due to numerical imprecision.  Under most circumstances, the
		/// error is not noticeable.
		/// </summary>
		// Token: 0x0600AA16 RID: 43542 RVA: 0x000F1D3F File Offset: 0x000EFF3F
		public virtual void SetIncrementalPreIntegration(int _arg)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIncrementalPreIntegration_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA17 RID: 43543
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrationTableLengthResolution_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the size of the integration table built.
		/// </summary>
		// Token: 0x0600AA18 RID: 43544 RVA: 0x000F1D4F File Offset: 0x000EFF4F
		public virtual void SetIntegrationTableLengthResolution(int _arg)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIntegrationTableLengthResolution_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA19 RID: 43545
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrationTableScalarResolution_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the size of the integration table built.
		/// </summary>
		// Token: 0x0600AA1A RID: 43546 RVA: 0x000F1D5F File Offset: 0x000EFF5F
		public virtual void SetIntegrationTableScalarResolution(int _arg)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIntegrationTableScalarResolution_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA1B RID: 43547
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrator_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The class used to fill the pre integration table.  By default, a
		/// vtkUnstructuredGridPartialPreIntegration is built.
		/// </summary>
		// Token: 0x0600AA1C RID: 43548 RVA: 0x000F1D70 File Offset: 0x000EFF70
		public virtual void SetIntegrator(vtkUnstructuredGridVolumeRayIntegrator arg0)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIntegrator_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D85 RID: 3461
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridPreIntegration";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D86 RID: 3462
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridPreIntegration";
	}
}
