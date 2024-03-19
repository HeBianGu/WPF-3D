using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLODProp3D
	/// </summary>
	/// <remarks>
	///    level of detail 3D prop
	///
	/// vtkLODProp3D is a class to support level of detail rendering for Prop3D.
	/// Any number of mapper/property/texture items can be added to this object.
	/// Render time will be measured, and will be used to select a LOD based on
	/// the AllocatedRenderTime of this Prop3D. Depending on the type of the
	/// mapper/property, a vtkActor or a vtkVolume will be created behind the
	/// scenes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp3D vtkActor vtkVolume vtkLODActor
	/// </seealso>
	// Token: 0x02000811 RID: 2065
	public class vtkLODProp3D : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060153AA RID: 86954 RVA: 0x001E0F6B File Offset: 0x001DF16B
		static vtkLODProp3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLODProp3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLODProp3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060153AB RID: 86955 RVA: 0x001E0F93 File Offset: 0x001DF193
		public vtkLODProp3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060153AC RID: 86956
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODProp3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x060153AD RID: 86957 RVA: 0x001E0FA4 File Offset: 0x001DF1A4
		public new static vtkLODProp3D New()
		{
			vtkLODProp3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x060153AE RID: 86958 RVA: 0x001E0FF8 File Offset: 0x001DF1F8
		public vtkLODProp3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLODProp3D.vtkLODProp3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060153AF RID: 86959 RVA: 0x001E103C File Offset: 0x001DF23C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060153B0 RID: 86960
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_AddEstimatedRenderTime_01(HandleRef pThis, double t, HandleRef vp);

		/// <summary>
		/// Override method from vtkProp in order to push this call down to the
		/// selected LOD as well.
		/// </summary>
		// Token: 0x060153B1 RID: 86961 RVA: 0x001E1048 File Offset: 0x001DF248
		public override void AddEstimatedRenderTime(double t, vtkViewport vp)
		{
			vtkLODProp3D.vtkLODProp3D_AddEstimatedRenderTime_01(base.GetCppThis(), t, (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x060153B2 RID: 86962
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_02(HandleRef pThis, HandleRef m, HandleRef p, HandleRef back, HandleRef t, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153B3 RID: 86963 RVA: 0x001E1078 File Offset: 0x001DF278
		public int AddLOD(vtkMapper m, vtkProperty p, vtkProperty back, vtkTexture t, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_02(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (back == null) ? default(HandleRef) : back.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), time);
		}

		// Token: 0x060153B4 RID: 86964
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_03(HandleRef pThis, HandleRef m, HandleRef p, HandleRef t, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153B5 RID: 86965 RVA: 0x001E10F0 File Offset: 0x001DF2F0
		public int AddLOD(vtkMapper m, vtkProperty p, vtkTexture t, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_03(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), time);
		}

		// Token: 0x060153B6 RID: 86966
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_04(HandleRef pThis, HandleRef m, HandleRef p, HandleRef back, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153B7 RID: 86967 RVA: 0x001E1150 File Offset: 0x001DF350
		public int AddLOD(vtkMapper m, vtkProperty p, vtkProperty back, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_04(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (back == null) ? default(HandleRef) : back.GetCppThis(), time);
		}

		// Token: 0x060153B8 RID: 86968
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_05(HandleRef pThis, HandleRef m, HandleRef p, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153B9 RID: 86969 RVA: 0x001E11B0 File Offset: 0x001DF3B0
		public int AddLOD(vtkMapper m, vtkProperty p, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_05(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), time);
		}

		// Token: 0x060153BA RID: 86970
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_06(HandleRef pThis, HandleRef m, HandleRef t, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153BB RID: 86971 RVA: 0x001E11FC File Offset: 0x001DF3FC
		public int AddLOD(vtkMapper m, vtkTexture t, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_06(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), time);
		}

		// Token: 0x060153BC RID: 86972
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_07(HandleRef pThis, HandleRef m, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153BD RID: 86973 RVA: 0x001E1248 File Offset: 0x001DF448
		public int AddLOD(vtkMapper m, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_07(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), time);
		}

		// Token: 0x060153BE RID: 86974
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_08(HandleRef pThis, HandleRef m, HandleRef p, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153BF RID: 86975 RVA: 0x001E1280 File Offset: 0x001DF480
		public int AddLOD(vtkAbstractVolumeMapper m, vtkVolumeProperty p, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_08(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), time);
		}

		// Token: 0x060153C0 RID: 86976
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_09(HandleRef pThis, HandleRef m, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153C1 RID: 86977 RVA: 0x001E12CC File Offset: 0x001DF4CC
		public int AddLOD(vtkAbstractVolumeMapper m, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_09(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), time);
		}

		// Token: 0x060153C2 RID: 86978
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_10(HandleRef pThis, HandleRef m, HandleRef p, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153C3 RID: 86979 RVA: 0x001E1304 File Offset: 0x001DF504
		public int AddLOD(vtkImageMapper3D m, vtkImageProperty p, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_10(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), time);
		}

		// Token: 0x060153C4 RID: 86980
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_AddLOD_11(HandleRef pThis, HandleRef m, double time);

		/// <summary>
		/// Add a level of detail with a given mapper, property, backface property,
		/// texture, and guess of rendering time.  The property and texture fields
		/// can be set to NULL (the other methods are included for script access
		/// where null variables are not allowed). The time field can be set to 0.0
		/// indicating that no initial guess for rendering time is being supplied.
		/// The returned integer value is an ID that can be used later to delete
		/// this LOD, or set it as the selected LOD.
		/// </summary>
		// Token: 0x060153C5 RID: 86981 RVA: 0x001E1350 File Offset: 0x001DF550
		public int AddLOD(vtkImageMapper3D m, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_11(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), time);
		}

		// Token: 0x060153C6 RID: 86982
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_AutomaticLODSelectionOff_12(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153C7 RID: 86983 RVA: 0x001E1385 File Offset: 0x001DF585
		public virtual void AutomaticLODSelectionOff()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticLODSelectionOff_12(base.GetCppThis());
		}

		// Token: 0x060153C8 RID: 86984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_AutomaticLODSelectionOn_13(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153C9 RID: 86985 RVA: 0x001E1394 File Offset: 0x001DF594
		public virtual void AutomaticLODSelectionOn()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticLODSelectionOn_13(base.GetCppThis());
		}

		// Token: 0x060153CA RID: 86986
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_AutomaticPickLODSelectionOff_14(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of picking LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153CB RID: 86987 RVA: 0x001E13A3 File Offset: 0x001DF5A3
		public virtual void AutomaticPickLODSelectionOff()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticPickLODSelectionOff_14(base.GetCppThis());
		}

		// Token: 0x060153CC RID: 86988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_AutomaticPickLODSelectionOn_15(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of picking LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153CD RID: 86989 RVA: 0x001E13B2 File Offset: 0x001DF5B2
		public virtual void AutomaticPickLODSelectionOn()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticPickLODSelectionOn_15(base.GetCppThis());
		}

		// Token: 0x060153CE RID: 86990
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_DisableLOD_16(HandleRef pThis, int id);

		/// <summary>
		/// Enable / disable a particular LOD. If it is disabled, it will not
		/// be used during automatic selection, but can be selected as the
		/// LOD if automatic LOD selection is off.
		/// </summary>
		// Token: 0x060153CF RID: 86991 RVA: 0x001E13C1 File Offset: 0x001DF5C1
		public void DisableLOD(int id)
		{
			vtkLODProp3D.vtkLODProp3D_DisableLOD_16(base.GetCppThis(), id);
		}

		// Token: 0x060153D0 RID: 86992
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_EnableLOD_17(HandleRef pThis, int id);

		/// <summary>
		/// Enable / disable a particular LOD. If it is disabled, it will not
		/// be used during automatic selection, but can be selected as the
		/// LOD if automatic LOD selection is off.
		/// </summary>
		// Token: 0x060153D1 RID: 86993 RVA: 0x001E13D1 File Offset: 0x001DF5D1
		public void EnableLOD(int id)
		{
			vtkLODProp3D.vtkLODProp3D_EnableLOD_17(base.GetCppThis(), id);
		}

		// Token: 0x060153D2 RID: 86994
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_GetActors_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x060153D3 RID: 86995 RVA: 0x001E13E4 File Offset: 0x001DF5E4
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkLODProp3D.vtkLODProp3D_GetActors_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060153D4 RID: 86996
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetAutomaticLODSelection_19(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153D5 RID: 86997 RVA: 0x001E1414 File Offset: 0x001DF614
		public virtual int GetAutomaticLODSelection()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticLODSelection_19(base.GetCppThis());
		}

		// Token: 0x060153D6 RID: 86998
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetAutomaticLODSelectionMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153D7 RID: 86999 RVA: 0x001E1434 File Offset: 0x001DF634
		public virtual int GetAutomaticLODSelectionMaxValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticLODSelectionMaxValue_20(base.GetCppThis());
		}

		// Token: 0x060153D8 RID: 87000
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetAutomaticLODSelectionMinValue_21(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153D9 RID: 87001 RVA: 0x001E1454 File Offset: 0x001DF654
		public virtual int GetAutomaticLODSelectionMinValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticLODSelectionMinValue_21(base.GetCppThis());
		}

		// Token: 0x060153DA RID: 87002
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetAutomaticPickLODSelection_22(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of picking LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153DB RID: 87003 RVA: 0x001E1474 File Offset: 0x001DF674
		public virtual int GetAutomaticPickLODSelection()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticPickLODSelection_22(base.GetCppThis());
		}

		// Token: 0x060153DC RID: 87004
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetAutomaticPickLODSelectionMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of picking LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153DD RID: 87005 RVA: 0x001E1494 File Offset: 0x001DF694
		public virtual int GetAutomaticPickLODSelectionMaxValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticPickLODSelectionMaxValue_23(base.GetCppThis());
		}

		// Token: 0x060153DE RID: 87006
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetAutomaticPickLODSelectionMinValue_24(HandleRef pThis);

		/// <summary>
		/// Turn on / off automatic selection of picking LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x060153DF RID: 87007 RVA: 0x001E14B4 File Offset: 0x001DF6B4
		public virtual int GetAutomaticPickLODSelectionMinValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticPickLODSelectionMinValue_24(base.GetCppThis());
		}

		// Token: 0x060153E0 RID: 87008
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODProp3D_GetBounds_25(HandleRef pThis);

		/// <summary>
		/// Standard vtkProp method to get 3D bounds of a 3D prop
		/// </summary>
		// Token: 0x060153E1 RID: 87009 RVA: 0x001E14D4 File Offset: 0x001DF6D4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_GetBounds_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060153E2 RID: 87010
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_GetBounds_26(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Standard vtkProp method to get 3D bounds of a 3D prop
		/// </summary>
		// Token: 0x060153E3 RID: 87011 RVA: 0x001E151C File Offset: 0x001DF71C
		public new void GetBounds(IntPtr bounds)
		{
			vtkLODProp3D.vtkLODProp3D_GetBounds_26(base.GetCppThis(), bounds);
		}

		// Token: 0x060153E4 RID: 87012
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetCurrentIndex_27(HandleRef pThis);

		/// <summary>
		/// Get the current index, used to determine the ID of the next LOD that is
		/// added.  Useful for guessing what IDs have been used (with NumberOfLODs,
		/// without depending on the constructor initialization to 1000.
		/// </summary>
		// Token: 0x060153E5 RID: 87013 RVA: 0x001E152C File Offset: 0x001DF72C
		public virtual int GetCurrentIndex()
		{
			return vtkLODProp3D.vtkLODProp3D_GetCurrentIndex_27(base.GetCppThis());
		}

		// Token: 0x060153E6 RID: 87014
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLODProp3D_GetLODEstimatedRenderTime_28(HandleRef pThis, int id);

		/// <summary>
		/// Access method that can be used to find out the estimated render time
		/// (the thing used to select an LOD) for a given LOD ID or index.
		/// Value is returned in seconds.
		/// </summary>
		// Token: 0x060153E7 RID: 87015 RVA: 0x001E154C File Offset: 0x001DF74C
		public double GetLODEstimatedRenderTime(int id)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODEstimatedRenderTime_28(base.GetCppThis(), id);
		}

		// Token: 0x060153E8 RID: 87016
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLODProp3D_GetLODIndexEstimatedRenderTime_29(HandleRef pThis, int index);

		/// <summary>
		/// Access method that can be used to find out the estimated render time
		/// (the thing used to select an LOD) for a given LOD ID or index.
		/// Value is returned in seconds.
		/// </summary>
		// Token: 0x060153E9 RID: 87017 RVA: 0x001E156C File Offset: 0x001DF76C
		public double GetLODIndexEstimatedRenderTime(int index)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODIndexEstimatedRenderTime_29(base.GetCppThis(), index);
		}

		// Token: 0x060153EA RID: 87018
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLODProp3D_GetLODIndexLevel_30(HandleRef pThis, int index);

		/// <summary>
		/// Set the level of a particular LOD. When a LOD is selected for
		/// rendering because it has the largest render time that fits within
		/// the allocated time, all LOD are then checked to see if any one can
		/// render faster but has a lower (more resolution/better) level.
		/// This quantity is a double to ensure that a level can be inserted
		/// between 2 and 3.
		/// </summary>
		// Token: 0x060153EB RID: 87019 RVA: 0x001E158C File Offset: 0x001DF78C
		public double GetLODIndexLevel(int index)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODIndexLevel_30(base.GetCppThis(), index);
		}

		// Token: 0x060153EC RID: 87020
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLODProp3D_GetLODLevel_31(HandleRef pThis, int id);

		/// <summary>
		/// Set the level of a particular LOD. When a LOD is selected for
		/// rendering because it has the largest render time that fits within
		/// the allocated time, all LOD are then checked to see if any one can
		/// render faster but has a lower (more resolution/better) level.
		/// This quantity is a double to ensure that a level can be inserted
		/// between 2 and 3.
		/// </summary>
		// Token: 0x060153ED RID: 87021 RVA: 0x001E15AC File Offset: 0x001DF7AC
		public double GetLODLevel(int id)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODLevel_31(base.GetCppThis(), id);
		}

		// Token: 0x060153EE RID: 87022
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODProp3D_GetLODMapper_32(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the LODMapper as an vtkAbstractMapper3D.  It is the user's
		/// respondibility to safe down cast this to a vtkMapper or vtkVolumeMapper
		/// as appropriate.
		/// </summary>
		// Token: 0x060153EF RID: 87023 RVA: 0x001E15CC File Offset: 0x001DF7CC
		public vtkAbstractMapper3D GetLODMapper(int id)
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_GetLODMapper_32(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}

		// Token: 0x060153F0 RID: 87024
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetLastRenderedLODID_33(HandleRef pThis);

		/// <summary>
		/// Get the ID of the previously (during the last render) selected LOD index
		/// </summary>
		// Token: 0x060153F1 RID: 87025 RVA: 0x001E163C File Offset: 0x001DF83C
		public int GetLastRenderedLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetLastRenderedLODID_33(base.GetCppThis());
		}

		// Token: 0x060153F2 RID: 87026
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLODProp3D_GetNumberOfGenerationsFromBase_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x060153F3 RID: 87027 RVA: 0x001E165C File Offset: 0x001DF85C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLODProp3D.vtkLODProp3D_GetNumberOfGenerationsFromBase_34(base.GetCppThis(), type);
		}

		// Token: 0x060153F4 RID: 87028
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLODProp3D_GetNumberOfGenerationsFromBaseType_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x060153F5 RID: 87029 RVA: 0x001E167C File Offset: 0x001DF87C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLODProp3D.vtkLODProp3D_GetNumberOfGenerationsFromBaseType_35(type);
		}

		// Token: 0x060153F6 RID: 87030
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetNumberOfLODs_36(HandleRef pThis);

		/// <summary>
		/// Get the current number of LODs.
		/// </summary>
		// Token: 0x060153F7 RID: 87031 RVA: 0x001E1698 File Offset: 0x001DF898
		public virtual int GetNumberOfLODs()
		{
			return vtkLODProp3D.vtkLODProp3D_GetNumberOfLODs_36(base.GetCppThis());
		}

		// Token: 0x060153F8 RID: 87032
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetPickLODID_37(HandleRef pThis);

		/// <summary>
		/// Get the ID of the appropriate pick LOD index
		/// </summary>
		// Token: 0x060153F9 RID: 87033 RVA: 0x001E16B8 File Offset: 0x001DF8B8
		public int GetPickLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetPickLODID_37(base.GetCppThis());
		}

		// Token: 0x060153FA RID: 87034
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetSelectedLODID_38(HandleRef pThis);

		/// <summary>
		/// Set the id of the LOD that is to be drawn when automatic LOD selection
		/// is turned off.
		/// </summary>
		// Token: 0x060153FB RID: 87035 RVA: 0x001E16D8 File Offset: 0x001DF8D8
		public virtual int GetSelectedLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetSelectedLODID_38(base.GetCppThis());
		}

		// Token: 0x060153FC RID: 87036
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_GetSelectedPickLODID_39(HandleRef pThis);

		/// <summary>
		/// Set the id of the LOD that is to be used for picking when automatic
		/// LOD pick selection is turned off.
		/// </summary>
		// Token: 0x060153FD RID: 87037 RVA: 0x001E16F8 File Offset: 0x001DF8F8
		public virtual int GetSelectedPickLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetSelectedPickLODID_39(base.GetCppThis());
		}

		// Token: 0x060153FE RID: 87038
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_GetVolumes_40(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x060153FF RID: 87039 RVA: 0x001E1718 File Offset: 0x001DF918
		public override void GetVolumes(vtkPropCollection arg0)
		{
			vtkLODProp3D.vtkLODProp3D_GetVolumes_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06015400 RID: 87040
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_HasTranslucentPolygonalGeometry_41(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x06015401 RID: 87041 RVA: 0x001E1748 File Offset: 0x001DF948
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLODProp3D.vtkLODProp3D_HasTranslucentPolygonalGeometry_41(base.GetCppThis());
		}

		// Token: 0x06015402 RID: 87042
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_IsA_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x06015403 RID: 87043 RVA: 0x001E1768 File Offset: 0x001DF968
		public override int IsA(string type)
		{
			return vtkLODProp3D.vtkLODProp3D_IsA_42(base.GetCppThis(), type);
		}

		// Token: 0x06015404 RID: 87044
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_IsLODEnabled_43(HandleRef pThis, int id);

		/// <summary>
		/// Enable / disable a particular LOD. If it is disabled, it will not
		/// be used during automatic selection, but can be selected as the
		/// LOD if automatic LOD selection is off.
		/// </summary>
		// Token: 0x06015405 RID: 87045 RVA: 0x001E1788 File Offset: 0x001DF988
		public int IsLODEnabled(int id)
		{
			return vtkLODProp3D.vtkLODProp3D_IsLODEnabled_43(base.GetCppThis(), id);
		}

		// Token: 0x06015406 RID: 87046
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_IsTypeOf_44([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x06015407 RID: 87047 RVA: 0x001E17A8 File Offset: 0x001DF9A8
		public new static int IsTypeOf(string type)
		{
			return vtkLODProp3D.vtkLODProp3D_IsTypeOf_44(type);
		}

		// Token: 0x06015408 RID: 87048
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODProp3D_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x06015409 RID: 87049 RVA: 0x001E17C4 File Offset: 0x001DF9C4
		public new vtkLODProp3D NewInstance()
		{
			vtkLODProp3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_NewInstance_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601540A RID: 87050
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_ReleaseGraphicsResources_47(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0601540B RID: 87051 RVA: 0x001E1820 File Offset: 0x001DFA20
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLODProp3D.vtkLODProp3D_ReleaseGraphicsResources_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601540C RID: 87052
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_RemoveLOD_48(HandleRef pThis, int id);

		/// <summary>
		/// Delete a level of detail given an ID. This is the ID returned by the
		/// AddLOD method
		/// </summary>
		// Token: 0x0601540D RID: 87053 RVA: 0x001E184F File Offset: 0x001DFA4F
		public void RemoveLOD(int id)
		{
			vtkLODProp3D.vtkLODProp3D_RemoveLOD_48(base.GetCppThis(), id);
		}

		// Token: 0x0601540E RID: 87054
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_RenderOpaqueGeometry_49(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0601540F RID: 87055 RVA: 0x001E1860 File Offset: 0x001DFA60
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLODProp3D.vtkLODProp3D_RenderOpaqueGeometry_49(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06015410 RID: 87056
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_RenderTranslucentPolygonalGeometry_50(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06015411 RID: 87057 RVA: 0x001E1894 File Offset: 0x001DFA94
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkLODProp3D.vtkLODProp3D_RenderTranslucentPolygonalGeometry_50(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06015412 RID: 87058
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLODProp3D_RenderVolumetricGeometry_51(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06015413 RID: 87059 RVA: 0x001E18C8 File Offset: 0x001DFAC8
		public override int RenderVolumetricGeometry(vtkViewport viewport)
		{
			return vtkLODProp3D.vtkLODProp3D_RenderVolumetricGeometry_51(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06015414 RID: 87060
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_RestoreEstimatedRenderTime_52(HandleRef pThis);

		/// <summary>
		/// Used when the render process is aborted to restore the previous
		/// estimated render time. Overridden here to allow previous time for a
		/// particular LOD to be restored - otherwise the time for the last rendered
		/// LOD will be copied into the currently selected LOD.
		/// </summary>
		// Token: 0x06015415 RID: 87061 RVA: 0x001E18FC File Offset: 0x001DFAFC
		public override void RestoreEstimatedRenderTime()
		{
			vtkLODProp3D.vtkLODProp3D_RestoreEstimatedRenderTime_52(base.GetCppThis());
		}

		// Token: 0x06015416 RID: 87062
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLODProp3D_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an instance of this class.
		/// </summary>
		// Token: 0x06015417 RID: 87063 RVA: 0x001E190C File Offset: 0x001DFB0C
		public new static vtkLODProp3D SafeDownCast(vtkObjectBase o)
		{
			vtkLODProp3D vtkLODProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_SafeDownCast_53((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLODProp3D = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLODProp3D.Register(null);
				}
			}
			return vtkLODProp3D;
		}

		// Token: 0x06015418 RID: 87064
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetAllocatedRenderTime_54(HandleRef pThis, double t, HandleRef vp);

		/// <summary>
		/// Used by the culler / renderer to set the allocated render time for this
		/// prop. This is based on the desired update rate, and possibly some other
		/// properties such as potential screen coverage of this prop.
		/// </summary>
		// Token: 0x06015419 RID: 87065 RVA: 0x001E198C File Offset: 0x001DFB8C
		public override void SetAllocatedRenderTime(double t, vtkViewport vp)
		{
			vtkLODProp3D.vtkLODProp3D_SetAllocatedRenderTime_54(base.GetCppThis(), t, (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0601541A RID: 87066
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetAutomaticLODSelection_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on / off automatic selection of LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x0601541B RID: 87067 RVA: 0x001E19BC File Offset: 0x001DFBBC
		public virtual void SetAutomaticLODSelection(int _arg)
		{
			vtkLODProp3D.vtkLODProp3D_SetAutomaticLODSelection_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0601541C RID: 87068
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetAutomaticPickLODSelection_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on / off automatic selection of picking LOD.
		/// This is on by default. If it is off, then the SelectedLODID is
		/// rendered regardless of rendering time or desired update rate.
		/// </summary>
		// Token: 0x0601541D RID: 87069 RVA: 0x001E19CC File Offset: 0x001DFBCC
		public virtual void SetAutomaticPickLODSelection(int _arg)
		{
			vtkLODProp3D.vtkLODProp3D_SetAutomaticPickLODSelection_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0601541E RID: 87070
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODBackfaceProperty_57(HandleRef pThis, int id, HandleRef t);

		/// <summary>
		/// Methods to set / get the backface property of an LOD. This method is only
		/// valid for LOD ids that are Actors (not Volumes)
		/// </summary>
		// Token: 0x0601541F RID: 87071 RVA: 0x001E19DC File Offset: 0x001DFBDC
		public void SetLODBackfaceProperty(int id, vtkProperty t)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODBackfaceProperty_57(base.GetCppThis(), id, (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06015420 RID: 87072
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODLevel_58(HandleRef pThis, int id, double level);

		/// <summary>
		/// Set the level of a particular LOD. When a LOD is selected for
		/// rendering because it has the largest render time that fits within
		/// the allocated time, all LOD are then checked to see if any one can
		/// render faster but has a lower (more resolution/better) level.
		/// This quantity is a double to ensure that a level can be inserted
		/// between 2 and 3.
		/// </summary>
		// Token: 0x06015421 RID: 87073 RVA: 0x001E1A0C File Offset: 0x001DFC0C
		public void SetLODLevel(int id, double level)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODLevel_58(base.GetCppThis(), id, level);
		}

		// Token: 0x06015422 RID: 87074
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODMapper_59(HandleRef pThis, int id, HandleRef m);

		/// <summary>
		/// Methods to set / get the mapper of an LOD. Since the LOD could be
		/// a volume or an actor, you have to pass in the pointer to the mapper
		/// to get it. The returned mapper will be NULL if the id is not valid,
		/// or the mapper is of the wrong type for the corresponding Prop3D.
		/// </summary>
		// Token: 0x06015423 RID: 87075 RVA: 0x001E1A20 File Offset: 0x001DFC20
		public void SetLODMapper(int id, vtkMapper m)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODMapper_59(base.GetCppThis(), id, (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06015424 RID: 87076
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODMapper_60(HandleRef pThis, int id, HandleRef m);

		/// <summary>
		/// Methods to set / get the mapper of an LOD. Since the LOD could be
		/// a volume or an actor, you have to pass in the pointer to the mapper
		/// to get it. The returned mapper will be NULL if the id is not valid,
		/// or the mapper is of the wrong type for the corresponding Prop3D.
		/// </summary>
		// Token: 0x06015425 RID: 87077 RVA: 0x001E1A50 File Offset: 0x001DFC50
		public void SetLODMapper(int id, vtkAbstractVolumeMapper m)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODMapper_60(base.GetCppThis(), id, (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06015426 RID: 87078
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODMapper_61(HandleRef pThis, int id, HandleRef m);

		/// <summary>
		/// Methods to set / get the mapper of an LOD. Since the LOD could be
		/// a volume or an actor, you have to pass in the pointer to the mapper
		/// to get it. The returned mapper will be NULL if the id is not valid,
		/// or the mapper is of the wrong type for the corresponding Prop3D.
		/// </summary>
		// Token: 0x06015427 RID: 87079 RVA: 0x001E1A80 File Offset: 0x001DFC80
		public void SetLODMapper(int id, vtkImageMapper3D m)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODMapper_61(base.GetCppThis(), id, (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06015428 RID: 87080
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODProperty_62(HandleRef pThis, int id, HandleRef p);

		/// <summary>
		/// Methods to set / get the property of an LOD. Since the LOD could be
		/// a volume or an actor, you have to pass in the pointer to the property
		/// to get it. The returned property will be NULL if the id is not valid,
		/// or the property is of the wrong type for the corresponding Prop3D.
		/// </summary>
		// Token: 0x06015429 RID: 87081 RVA: 0x001E1AB0 File Offset: 0x001DFCB0
		public void SetLODProperty(int id, vtkProperty p)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODProperty_62(base.GetCppThis(), id, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601542A RID: 87082
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODProperty_63(HandleRef pThis, int id, HandleRef p);

		/// <summary>
		/// Methods to set / get the property of an LOD. Since the LOD could be
		/// a volume or an actor, you have to pass in the pointer to the property
		/// to get it. The returned property will be NULL if the id is not valid,
		/// or the property is of the wrong type for the corresponding Prop3D.
		/// </summary>
		// Token: 0x0601542B RID: 87083 RVA: 0x001E1AE0 File Offset: 0x001DFCE0
		public void SetLODProperty(int id, vtkVolumeProperty p)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODProperty_63(base.GetCppThis(), id, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601542C RID: 87084
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODProperty_64(HandleRef pThis, int id, HandleRef p);

		/// <summary>
		/// Methods to set / get the property of an LOD. Since the LOD could be
		/// a volume or an actor, you have to pass in the pointer to the property
		/// to get it. The returned property will be NULL if the id is not valid,
		/// or the property is of the wrong type for the corresponding Prop3D.
		/// </summary>
		// Token: 0x0601542D RID: 87085 RVA: 0x001E1B10 File Offset: 0x001DFD10
		public void SetLODProperty(int id, vtkImageProperty p)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODProperty_64(base.GetCppThis(), id, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601542E RID: 87086
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetLODTexture_65(HandleRef pThis, int id, HandleRef t);

		/// <summary>
		/// Methods to set / get the texture of an LOD. This method is only
		/// valid for LOD ids that are Actors (not Volumes)
		/// </summary>
		// Token: 0x0601542F RID: 87087 RVA: 0x001E1B40 File Offset: 0x001DFD40
		public void SetLODTexture(int id, vtkTexture t)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODTexture_65(base.GetCppThis(), id, (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06015430 RID: 87088
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetSelectedLODID_66(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the id of the LOD that is to be drawn when automatic LOD selection
		/// is turned off.
		/// </summary>
		// Token: 0x06015431 RID: 87089 RVA: 0x001E1B70 File Offset: 0x001DFD70
		public virtual void SetSelectedLODID(int _arg)
		{
			vtkLODProp3D.vtkLODProp3D_SetSelectedLODID_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06015432 RID: 87090
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_SetSelectedPickLODID_67(HandleRef pThis, int id);

		/// <summary>
		/// Set the id of the LOD that is to be used for picking when automatic
		/// LOD pick selection is turned off.
		/// </summary>
		// Token: 0x06015433 RID: 87091 RVA: 0x001E1B80 File Offset: 0x001DFD80
		public void SetSelectedPickLODID(int id)
		{
			vtkLODProp3D.vtkLODProp3D_SetSelectedPickLODID_67(base.GetCppThis(), id);
		}

		// Token: 0x06015434 RID: 87092
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLODProp3D_ShallowCopy_68(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkLODProp3D.
		/// </summary>
		// Token: 0x06015435 RID: 87093 RVA: 0x001E1B90 File Offset: 0x001DFD90
		public override void ShallowCopy(vtkProp prop)
		{
			vtkLODProp3D.vtkLODProp3D_ShallowCopy_68(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400186A RID: 6250
		public new const string MRFullTypeName = "Kitware.VTK.vtkLODProp3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400186B RID: 6251
		public new static readonly string MRClassNameKey = "class vtkLODProp3D";
	}
}
