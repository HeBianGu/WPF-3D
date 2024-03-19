using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeMapper
	/// </summary>
	/// <remarks>
	///    Mapper that draws vtkMolecule objects
	///
	///
	/// vtkMoleculeMapper uses glyphs (display lists) to quickly render a
	/// molecule.
	/// </remarks>
	// Token: 0x02000577 RID: 1399
	public class vtkMoleculeMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F7CA RID: 63434 RVA: 0x001586F3 File Offset: 0x001568F3
		static vtkMoleculeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F7CB RID: 63435 RVA: 0x0015871B File Offset: 0x0015691B
		public vtkMoleculeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F7CC RID: 63436
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7CD RID: 63437 RVA: 0x0015872C File Offset: 0x0015692C
		public new static vtkMoleculeMapper New()
		{
			vtkMoleculeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7CE RID: 63438 RVA: 0x00158780 File Offset: 0x00156980
		public vtkMoleculeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMoleculeMapper.vtkMoleculeMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F7CF RID: 63439 RVA: 0x001587C4 File Offset: 0x001569C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F7D0 RID: 63440
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F7D1 RID: 63441 RVA: 0x001587D0 File Offset: 0x001569D0
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600F7D2 RID: 63442
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetAtomColor_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the color of the atoms as an rgb tuple.
		/// Default: {150, 150, 150} (grey)
		/// </summary>
		// Token: 0x0600F7D3 RID: 63443 RVA: 0x00158808 File Offset: 0x00156A08
		public virtual byte[] GetAtomColor()
		{
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_GetAtomColor_02(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F7D4 RID: 63444
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetAtomColor_03(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

		/// <summary>
		/// Get/Set the color of the atoms as an rgb tuple.
		/// Default: {150, 150, 150} (grey)
		/// </summary>
		// Token: 0x0600F7D5 RID: 63445 RVA: 0x00158850 File Offset: 0x00156A50
		public virtual void GetAtomColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetAtomColor_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F7D6 RID: 63446
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetAtomColor_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color of the atoms as an rgb tuple.
		/// Default: {150, 150, 150} (grey)
		/// </summary>
		// Token: 0x0600F7D7 RID: 63447 RVA: 0x00158862 File Offset: 0x00156A62
		public virtual void GetAtomColor(IntPtr _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetAtomColor_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F7D8 RID: 63448
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetAtomColorMode_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which atoms are colored.
		///
		/// If 'SingleColor' is used, all atoms will have the same color. Use
		/// SetAtomColor to set the rgb values to be used.
		///
		/// If 'DiscreteByAtom' is selected, each atom is colored using the
		/// internal lookup table.
		/// </summary>
		// Token: 0x0600F7D9 RID: 63449 RVA: 0x00158874 File Offset: 0x00156A74
		public virtual int GetAtomColorMode()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetAtomColorMode_05(base.GetCppThis());
		}

		// Token: 0x0600F7DA RID: 63450
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetAtomColorModeMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which atoms are colored.
		///
		/// If 'SingleColor' is used, all atoms will have the same color. Use
		/// SetAtomColor to set the rgb values to be used.
		///
		/// If 'DiscreteByAtom' is selected, each atom is colored using the
		/// internal lookup table.
		/// </summary>
		// Token: 0x0600F7DB RID: 63451 RVA: 0x00158894 File Offset: 0x00156A94
		public virtual int GetAtomColorModeMaxValue()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetAtomColorModeMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600F7DC RID: 63452
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetAtomColorModeMinValue_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which atoms are colored.
		///
		/// If 'SingleColor' is used, all atoms will have the same color. Use
		/// SetAtomColor to set the rgb values to be used.
		///
		/// If 'DiscreteByAtom' is selected, each atom is colored using the
		/// internal lookup table.
		/// </summary>
		// Token: 0x0600F7DD RID: 63453 RVA: 0x001588B4 File Offset: 0x00156AB4
		public virtual int GetAtomColorModeMinValue()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetAtomColorModeMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600F7DE RID: 63454
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetAtomicRadiusArrayName_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the atomic radius array name. Default: "radii"
		/// It is only used when AtomicRadiusType is set to CustomArrayRadius.
		/// </summary>
		// Token: 0x0600F7DF RID: 63455 RVA: 0x001588D4 File Offset: 0x00156AD4
		public virtual string GetAtomicRadiusArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMoleculeMapper.vtkMoleculeMapper_GetAtomicRadiusArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F7E0 RID: 63456
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMoleculeMapper_GetAtomicRadiusScaleFactor_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the uniform scaling factor applied to the atoms.
		/// This is ignored when AtomicRadiusType == CustomArrayRadius.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600F7E1 RID: 63457 RVA: 0x00158910 File Offset: 0x00156B10
		public virtual float GetAtomicRadiusScaleFactor()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetAtomicRadiusScaleFactor_09(base.GetCppThis());
		}

		// Token: 0x0600F7E2 RID: 63458
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetAtomicRadiusType_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F7E3 RID: 63459 RVA: 0x00158930 File Offset: 0x00156B30
		public virtual int GetAtomicRadiusType()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetAtomicRadiusType_10(base.GetCppThis());
		}

		// Token: 0x0600F7E4 RID: 63460
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetAtomicRadiusTypeAsString_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F7E5 RID: 63461 RVA: 0x00158950 File Offset: 0x00156B50
		public string GetAtomicRadiusTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkMoleculeMapper.vtkMoleculeMapper_GetAtomicRadiusTypeAsString_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F7E6 RID: 63462
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetBondColor_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {50, 50, 50} (dark grey)
		/// </summary>
		// Token: 0x0600F7E7 RID: 63463 RVA: 0x0015898C File Offset: 0x00156B8C
		public virtual byte[] GetBondColor()
		{
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_GetBondColor_12(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F7E8 RID: 63464
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetBondColor_13(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {50, 50, 50} (dark grey)
		/// </summary>
		// Token: 0x0600F7E9 RID: 63465 RVA: 0x001589D4 File Offset: 0x00156BD4
		public virtual void GetBondColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetBondColor_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F7EA RID: 63466
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetBondColor_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {50, 50, 50} (dark grey)
		/// </summary>
		// Token: 0x0600F7EB RID: 63467 RVA: 0x001589E6 File Offset: 0x00156BE6
		public virtual void GetBondColor(IntPtr _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetBondColor_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F7EC RID: 63468
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetBondColorMode_15(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F7ED RID: 63469 RVA: 0x001589F8 File Offset: 0x00156BF8
		public virtual int GetBondColorMode()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetBondColorMode_15(base.GetCppThis());
		}

		// Token: 0x0600F7EE RID: 63470
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetBondColorModeAsString_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F7EF RID: 63471 RVA: 0x00158A18 File Offset: 0x00156C18
		public string GetBondColorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkMoleculeMapper.vtkMoleculeMapper_GetBondColorModeAsString_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F7F0 RID: 63472
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetBondColorModeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F7F1 RID: 63473 RVA: 0x00158A54 File Offset: 0x00156C54
		public virtual int GetBondColorModeMaxValue()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetBondColorModeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600F7F2 RID: 63474
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_GetBondColorModeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F7F3 RID: 63475 RVA: 0x00158A74 File Offset: 0x00156C74
		public virtual int GetBondColorModeMinValue()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetBondColorModeMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600F7F4 RID: 63476
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkMoleculeMapper_GetBondRadius_19(HandleRef pThis);

		/// <summary>
		/// Get/Set the radius of the bond cylinders. Default: 0.075
		/// </summary>
		// Token: 0x0600F7F5 RID: 63477 RVA: 0x00158A94 File Offset: 0x00156C94
		public virtual float GetBondRadius()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetBondRadius_19(base.GetCppThis());
		}

		// Token: 0x0600F7F6 RID: 63478
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetBounds_20(HandleRef pThis);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F7F7 RID: 63479 RVA: 0x00158AB4 File Offset: 0x00156CB4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_GetBounds_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F7F8 RID: 63480
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetBounds_21(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F7F9 RID: 63481 RVA: 0x00158AFC File Offset: 0x00156CFC
		public override void GetBounds(IntPtr bounds)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetBounds_21(base.GetCppThis(), bounds);
		}

		// Token: 0x0600F7FA RID: 63482
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetInput_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the input vtkMolecule.
		/// </summary>
		// Token: 0x0600F7FB RID: 63483 RVA: 0x00158B0C File Offset: 0x00156D0C
		public new vtkMolecule GetInput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_GetInput_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x0600F7FC RID: 63484
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetLatticeColor_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {255, 255, 255} (white)
		/// </summary>
		// Token: 0x0600F7FD RID: 63485 RVA: 0x00158B7C File Offset: 0x00156D7C
		public virtual byte[] GetLatticeColor()
		{
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_GetLatticeColor_23(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F7FE RID: 63486
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetLatticeColor_24(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {255, 255, 255} (white)
		/// </summary>
		// Token: 0x0600F7FF RID: 63487 RVA: 0x00158BC4 File Offset: 0x00156DC4
		public virtual void GetLatticeColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetLatticeColor_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F800 RID: 63488
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetLatticeColor_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {255, 255, 255} (white)
		/// </summary>
		// Token: 0x0600F801 RID: 63489 RVA: 0x00158BD6 File Offset: 0x00156DD6
		public virtual void GetLatticeColor(IntPtr _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetLatticeColor_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F802 RID: 63490
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeMapper_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F803 RID: 63491 RVA: 0x00158BE8 File Offset: 0x00156DE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x0600F804 RID: 63492
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeMapper_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F805 RID: 63493 RVA: 0x00158C08 File Offset: 0x00156E08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x0600F806 RID: 63494
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_GetPeriodicTable_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Accessor to internal structure. This is exposed to make it available for ray tracers.
		/// </summary>
		// Token: 0x0600F807 RID: 63495 RVA: 0x00158C24 File Offset: 0x00156E24
		public vtkPeriodicTable GetPeriodicTable()
		{
			vtkPeriodicTable vtkPeriodicTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_GetPeriodicTable_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPeriodicTable = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPeriodicTable.Register(null);
				}
			}
			return vtkPeriodicTable;
		}

		// Token: 0x0600F808 RID: 63496
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMoleculeMapper_GetRenderAtoms_29(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render atoms. Default: On.
		/// </summary>
		// Token: 0x0600F809 RID: 63497 RVA: 0x00158C94 File Offset: 0x00156E94
		public virtual bool GetRenderAtoms()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetRenderAtoms_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F80A RID: 63498
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMoleculeMapper_GetRenderBonds_30(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render bonds. Default: On.
		/// </summary>
		// Token: 0x0600F80B RID: 63499 RVA: 0x00158CBC File Offset: 0x00156EBC
		public virtual bool GetRenderBonds()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetRenderBonds_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F80C RID: 63500
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMoleculeMapper_GetRenderLattice_31(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render the unit cell lattice, if present.
		/// Default: On.
		/// </summary>
		// Token: 0x0600F80D RID: 63501 RVA: 0x00158CE4 File Offset: 0x00156EE4
		public virtual bool GetRenderLattice()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetRenderLattice_31(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F80E RID: 63502
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetSelectedAtoms_32(HandleRef pThis, HandleRef selection, HandleRef atomIds);

		/// <summary>
		/// Extract the ids atoms and/or bonds rendered by this molecule from a
		/// vtkSelection object. The vtkIdTypeArray
		/// </summary>
		// Token: 0x0600F80F RID: 63503 RVA: 0x00158D0C File Offset: 0x00156F0C
		public virtual void GetSelectedAtoms(vtkSelection selection, vtkIdTypeArray atomIds)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetSelectedAtoms_32(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), (atomIds == null) ? default(HandleRef) : atomIds.GetCppThis());
		}

		// Token: 0x0600F810 RID: 63504
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetSelectedAtomsAndBonds_33(HandleRef pThis, HandleRef selection, HandleRef atomIds, HandleRef bondIds);

		/// <summary>
		/// Extract the ids atoms and/or bonds rendered by this molecule from a
		/// vtkSelection object. The vtkIdTypeArray
		/// </summary>
		// Token: 0x0600F811 RID: 63505 RVA: 0x00158D50 File Offset: 0x00156F50
		public virtual void GetSelectedAtomsAndBonds(vtkSelection selection, vtkIdTypeArray atomIds, vtkIdTypeArray bondIds)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetSelectedAtomsAndBonds_33(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), (atomIds == null) ? default(HandleRef) : atomIds.GetCppThis(), (bondIds == null) ? default(HandleRef) : bondIds.GetCppThis());
		}

		// Token: 0x0600F812 RID: 63506
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_GetSelectedBonds_34(HandleRef pThis, HandleRef selection, HandleRef bondIds);

		/// <summary>
		/// Extract the ids atoms and/or bonds rendered by this molecule from a
		/// vtkSelection object. The vtkIdTypeArray
		/// </summary>
		// Token: 0x0600F813 RID: 63507 RVA: 0x00158DAC File Offset: 0x00156FAC
		public virtual void GetSelectedBonds(vtkSelection selection, vtkIdTypeArray bondIds)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_GetSelectedBonds_34(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), (bondIds == null) ? default(HandleRef) : bondIds.GetCppThis());
		}

		// Token: 0x0600F814 RID: 63508
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMoleculeMapper_GetSupportsSelection_35(HandleRef pThis);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F815 RID: 63509 RVA: 0x00158DF0 File Offset: 0x00156FF0
		public override bool GetSupportsSelection()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetSupportsSelection_35(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F816 RID: 63510
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMoleculeMapper_GetUseMultiCylindersForBonds_36(HandleRef pThis);

		/// <summary>
		/// Get/Set whether multicylinders will be used to represent multiple
		/// bonds. Default: On.
		/// </summary>
		// Token: 0x0600F817 RID: 63511 RVA: 0x00158E18 File Offset: 0x00157018
		public virtual bool GetUseMultiCylindersForBonds()
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_GetUseMultiCylindersForBonds_36(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F818 RID: 63512
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_IsA_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F819 RID: 63513 RVA: 0x00158E40 File Offset: 0x00157040
		public override int IsA(string type)
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_IsA_37(base.GetCppThis(), type);
		}

		// Token: 0x0600F81A RID: 63514
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeMapper_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F81B RID: 63515 RVA: 0x00158E60 File Offset: 0x00157060
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeMapper.vtkMoleculeMapper_IsTypeOf_38(type);
		}

		// Token: 0x0600F81C RID: 63516
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F81D RID: 63517 RVA: 0x00158E7C File Offset: 0x0015707C
		public new vtkMoleculeMapper NewInstance()
		{
			vtkMoleculeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F81E RID: 63518
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_ReleaseGraphicsResources_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F81F RID: 63519 RVA: 0x00158ED8 File Offset: 0x001570D8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_ReleaseGraphicsResources_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600F820 RID: 63520
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_Render_42(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F821 RID: 63521 RVA: 0x00158F08 File Offset: 0x00157108
		public override void Render(vtkRenderer arg0, vtkActor arg1)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_Render_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600F822 RID: 63522
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_RenderAtomsOff_43(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render atoms. Default: On.
		/// </summary>
		// Token: 0x0600F823 RID: 63523 RVA: 0x00158F4C File Offset: 0x0015714C
		public virtual void RenderAtomsOff()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_RenderAtomsOff_43(base.GetCppThis());
		}

		// Token: 0x0600F824 RID: 63524
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_RenderAtomsOn_44(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render atoms. Default: On.
		/// </summary>
		// Token: 0x0600F825 RID: 63525 RVA: 0x00158F5B File Offset: 0x0015715B
		public virtual void RenderAtomsOn()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_RenderAtomsOn_44(base.GetCppThis());
		}

		// Token: 0x0600F826 RID: 63526
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_RenderBondsOff_45(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render bonds. Default: On.
		/// </summary>
		// Token: 0x0600F827 RID: 63527 RVA: 0x00158F6A File Offset: 0x0015716A
		public virtual void RenderBondsOff()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_RenderBondsOff_45(base.GetCppThis());
		}

		// Token: 0x0600F828 RID: 63528
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_RenderBondsOn_46(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render bonds. Default: On.
		/// </summary>
		// Token: 0x0600F829 RID: 63529 RVA: 0x00158F79 File Offset: 0x00157179
		public virtual void RenderBondsOn()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_RenderBondsOn_46(base.GetCppThis());
		}

		// Token: 0x0600F82A RID: 63530
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_RenderLatticeOff_47(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render the unit cell lattice, if present.
		/// Default: On.
		/// </summary>
		// Token: 0x0600F82B RID: 63531 RVA: 0x00158F88 File Offset: 0x00157188
		public virtual void RenderLatticeOff()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_RenderLatticeOff_47(base.GetCppThis());
		}

		// Token: 0x0600F82C RID: 63532
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_RenderLatticeOn_48(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not to render the unit cell lattice, if present.
		/// Default: On.
		/// </summary>
		// Token: 0x0600F82D RID: 63533 RVA: 0x00158F97 File Offset: 0x00157197
		public virtual void RenderLatticeOn()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_RenderLatticeOn_48(base.GetCppThis());
		}

		// Token: 0x0600F82E RID: 63534
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeMapper_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F82F RID: 63535 RVA: 0x00158FA8 File Offset: 0x001571A8
		public new static vtkMoleculeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeMapper vtkMoleculeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeMapper.vtkMoleculeMapper_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeMapper = (vtkMoleculeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeMapper.Register(null);
				}
			}
			return vtkMoleculeMapper;
		}

		// Token: 0x0600F830 RID: 63536
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomColor_50(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

		/// <summary>
		/// Get/Set the color of the atoms as an rgb tuple.
		/// Default: {150, 150, 150} (grey)
		/// </summary>
		// Token: 0x0600F831 RID: 63537 RVA: 0x00159027 File Offset: 0x00157227
		public virtual void SetAtomColor(byte _arg1, byte _arg2, byte _arg3)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomColor_50(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F832 RID: 63538
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomColor_51(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color of the atoms as an rgb tuple.
		/// Default: {150, 150, 150} (grey)
		/// </summary>
		// Token: 0x0600F833 RID: 63539 RVA: 0x00159039 File Offset: 0x00157239
		public virtual void SetAtomColor(IntPtr _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomColor_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F834 RID: 63540
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomColorMode_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the method by which atoms are colored.
		///
		/// If 'SingleColor' is used, all atoms will have the same color. Use
		/// SetAtomColor to set the rgb values to be used.
		///
		/// If 'DiscreteByAtom' is selected, each atom is colored using the
		/// internal lookup table.
		/// </summary>
		// Token: 0x0600F835 RID: 63541 RVA: 0x00159049 File Offset: 0x00157249
		public virtual void SetAtomColorMode(int _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomColorMode_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F836 RID: 63542
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusArrayName_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the atomic radius array name. Default: "radii"
		/// It is only used when AtomicRadiusType is set to CustomArrayRadius.
		/// </summary>
		// Token: 0x0600F837 RID: 63543 RVA: 0x00159059 File Offset: 0x00157259
		public virtual void SetAtomicRadiusArrayName(string _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusArrayName_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F838 RID: 63544
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusScaleFactor_54(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the uniform scaling factor applied to the atoms.
		/// This is ignored when AtomicRadiusType == CustomArrayRadius.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600F839 RID: 63545 RVA: 0x00159069 File Offset: 0x00157269
		public virtual void SetAtomicRadiusScaleFactor(float _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusScaleFactor_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F83A RID: 63546
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusType_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F83B RID: 63547 RVA: 0x00159079 File Offset: 0x00157279
		public virtual void SetAtomicRadiusType(int _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusType_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F83C RID: 63548
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToCovalentRadius_56(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F83D RID: 63549 RVA: 0x00159089 File Offset: 0x00157289
		public void SetAtomicRadiusTypeToCovalentRadius()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusTypeToCovalentRadius_56(base.GetCppThis());
		}

		// Token: 0x0600F83E RID: 63550
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToCustomArrayRadius_57(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F83F RID: 63551 RVA: 0x00159098 File Offset: 0x00157298
		public void SetAtomicRadiusTypeToCustomArrayRadius()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusTypeToCustomArrayRadius_57(base.GetCppThis());
		}

		// Token: 0x0600F840 RID: 63552
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToUnitRadius_58(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F841 RID: 63553 RVA: 0x001590A7 File Offset: 0x001572A7
		public void SetAtomicRadiusTypeToUnitRadius()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusTypeToUnitRadius_58(base.GetCppThis());
		}

		// Token: 0x0600F842 RID: 63554
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToVDWRadius_59(HandleRef pThis);

		/// <summary>
		/// Get/Set the type of radius used to generate the atoms. Default:
		/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
		/// 'radii' is used for per-atom radii.
		/// </summary>
		// Token: 0x0600F843 RID: 63555 RVA: 0x001590B6 File Offset: 0x001572B6
		public void SetAtomicRadiusTypeToVDWRadius()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetAtomicRadiusTypeToVDWRadius_59(base.GetCppThis());
		}

		// Token: 0x0600F844 RID: 63556
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetBondColor_60(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {50, 50, 50} (dark grey)
		/// </summary>
		// Token: 0x0600F845 RID: 63557 RVA: 0x001590C5 File Offset: 0x001572C5
		public virtual void SetBondColor(byte _arg1, byte _arg2, byte _arg3)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetBondColor_60(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F846 RID: 63558
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetBondColor_61(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {50, 50, 50} (dark grey)
		/// </summary>
		// Token: 0x0600F847 RID: 63559 RVA: 0x001590D7 File Offset: 0x001572D7
		public virtual void SetBondColor(IntPtr _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetBondColor_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F848 RID: 63560
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetBondColorMode_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F849 RID: 63561 RVA: 0x001590E7 File Offset: 0x001572E7
		public virtual void SetBondColorMode(int _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetBondColorMode_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F84A RID: 63562
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetBondColorModeToDiscreteByAtom_63(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F84B RID: 63563 RVA: 0x001590F7 File Offset: 0x001572F7
		public void SetBondColorModeToDiscreteByAtom()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetBondColorModeToDiscreteByAtom_63(base.GetCppThis());
		}

		// Token: 0x0600F84C RID: 63564
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetBondColorModeToSingleColor_64(HandleRef pThis);

		/// <summary>
		/// Get/Set the method by which bonds are colored.
		///
		/// If 'SingleColor' is used, all bonds will be the same color. Use
		/// SetBondColor to set the rgb values used.
		///
		/// If 'DiscreteByAtom' is selected, each bond is colored using the
		/// same lookup table as the atoms at each end, with a sharp color
		/// boundary at the bond center.
		/// </summary>
		// Token: 0x0600F84D RID: 63565 RVA: 0x00159106 File Offset: 0x00157306
		public void SetBondColorModeToSingleColor()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetBondColorModeToSingleColor_64(base.GetCppThis());
		}

		// Token: 0x0600F84E RID: 63566
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetBondRadius_65(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set the radius of the bond cylinders. Default: 0.075
		/// </summary>
		// Token: 0x0600F84F RID: 63567 RVA: 0x00159115 File Offset: 0x00157315
		public virtual void SetBondRadius(float _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetBondRadius_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F850 RID: 63568
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetInputData_66(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the input vtkMolecule.
		/// </summary>
		// Token: 0x0600F851 RID: 63569 RVA: 0x00159128 File Offset: 0x00157328
		public void SetInputData(vtkMolecule arg0)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetInputData_66(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600F852 RID: 63570
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetLatticeColor_67(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {255, 255, 255} (white)
		/// </summary>
		// Token: 0x0600F853 RID: 63571 RVA: 0x00159157 File Offset: 0x00157357
		public virtual void SetLatticeColor(byte _arg1, byte _arg2, byte _arg3)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetLatticeColor_67(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F854 RID: 63572
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetLatticeColor_68(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the color of the bonds as an rgb tuple.
		/// Default: {255, 255, 255} (white)
		/// </summary>
		// Token: 0x0600F855 RID: 63573 RVA: 0x00159169 File Offset: 0x00157369
		public virtual void SetLatticeColor(IntPtr _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetLatticeColor_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F856 RID: 63574
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetMapScalars_69(HandleRef pThis, byte map);

		/// <summary>
		/// Helper method to set ScalarMode on both AtomGlyphMapper and BondGlyphMapper.
		/// true means VTK_COLOR_MODE_MAP_SCALARS, false VTK_COLOR_MODE_DIRECT_SCALARS.
		/// </summary>
		// Token: 0x0600F857 RID: 63575 RVA: 0x00159179 File Offset: 0x00157379
		public virtual void SetMapScalars(bool map)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetMapScalars_69(base.GetCppThis(), map ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F858 RID: 63576
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetRenderAtoms_70(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether or not to render atoms. Default: On.
		/// </summary>
		// Token: 0x0600F859 RID: 63577 RVA: 0x00159191 File Offset: 0x00157391
		public virtual void SetRenderAtoms(bool _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetRenderAtoms_70(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F85A RID: 63578
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetRenderBonds_71(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether or not to render bonds. Default: On.
		/// </summary>
		// Token: 0x0600F85B RID: 63579 RVA: 0x001591A9 File Offset: 0x001573A9
		public virtual void SetRenderBonds(bool _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetRenderBonds_71(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F85C RID: 63580
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetRenderLattice_72(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether or not to render the unit cell lattice, if present.
		/// Default: On.
		/// </summary>
		// Token: 0x0600F85D RID: 63581 RVA: 0x001591C1 File Offset: 0x001573C1
		public virtual void SetRenderLattice(bool _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetRenderLattice_72(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F85E RID: 63582
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_SetUseMultiCylindersForBonds_73(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether multicylinders will be used to represent multiple
		/// bonds. Default: On.
		/// </summary>
		// Token: 0x0600F85F RID: 63583 RVA: 0x001591D9 File Offset: 0x001573D9
		public virtual void SetUseMultiCylindersForBonds(bool _arg)
		{
			vtkMoleculeMapper.vtkMoleculeMapper_SetUseMultiCylindersForBonds_73(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F860 RID: 63584
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_UseBallAndStickSettings_74(HandleRef pThis);

		/// <summary>
		/// Set ivars to default ball-and-stick settings. This is equivalent
		/// to the following:
		/// - SetRenderAtoms( true )
		/// - SetRenderBonds( true )
		/// - SetAtomicRadiusType( VDWRadius )
		/// - SetAtomicRadiusScaleFactor( 0.3 )
		/// - SetBondColorMode( DiscreteByAtom )
		/// - SetUseMultiCylindersForBonds( true )
		/// - SetBondRadius( 0.075 )
		/// </summary>
		// Token: 0x0600F861 RID: 63585 RVA: 0x001591F1 File Offset: 0x001573F1
		public void UseBallAndStickSettings()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_UseBallAndStickSettings_74(base.GetCppThis());
		}

		// Token: 0x0600F862 RID: 63586
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_UseFastSettings_75(HandleRef pThis);

		/// <summary>
		/// Set ivars to use fast settings that may be useful for rendering
		/// extremely large molecules where the overall shape is more
		/// important than the details of the atoms/bond. This is equivalent
		/// to the following:
		/// - SetRenderAtoms( true )
		/// - SetRenderBonds( true )
		/// - SetAtomicRadiusType( UnitRadius )
		/// - SetAtomicRadiusScaleFactor( 0.60 )
		/// - SetBondColorMode( SingleColor )
		/// - SetBondColor( 50, 50, 50 )
		/// - SetUseMultiCylindersForBonds( false )
		/// - SetBondRadius( 0.075 )
		/// </summary>
		// Token: 0x0600F863 RID: 63587 RVA: 0x00159200 File Offset: 0x00157400
		public void UseFastSettings()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_UseFastSettings_75(base.GetCppThis());
		}

		// Token: 0x0600F864 RID: 63588
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_UseLiquoriceStickSettings_76(HandleRef pThis);

		/// <summary>
		/// Set ivars to default liquorice stick settings. This is
		/// equivalent to the following:
		/// - SetRenderAtoms( true )
		/// - SetRenderBonds( true )
		/// - SetAtomicRadiusType( UnitRadius )
		/// - SetAtomicRadiusScaleFactor( 0.1 )
		/// - SetBondColorMode( DiscreteByAtom )
		/// - SetUseMultiCylindersForBonds( false )
		/// - SetBondRadius( 0.1 )
		/// </summary>
		// Token: 0x0600F865 RID: 63589 RVA: 0x0015920F File Offset: 0x0015740F
		public void UseLiquoriceStickSettings()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_UseLiquoriceStickSettings_76(base.GetCppThis());
		}

		// Token: 0x0600F866 RID: 63590
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_UseMultiCylindersForBondsOff_77(HandleRef pThis);

		/// <summary>
		/// Get/Set whether multicylinders will be used to represent multiple
		/// bonds. Default: On.
		/// </summary>
		// Token: 0x0600F867 RID: 63591 RVA: 0x0015921E File Offset: 0x0015741E
		public virtual void UseMultiCylindersForBondsOff()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_UseMultiCylindersForBondsOff_77(base.GetCppThis());
		}

		// Token: 0x0600F868 RID: 63592
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_UseMultiCylindersForBondsOn_78(HandleRef pThis);

		/// <summary>
		/// Get/Set whether multicylinders will be used to represent multiple
		/// bonds. Default: On.
		/// </summary>
		// Token: 0x0600F869 RID: 63593 RVA: 0x0015922D File Offset: 0x0015742D
		public virtual void UseMultiCylindersForBondsOn()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_UseMultiCylindersForBondsOn_78(base.GetCppThis());
		}

		// Token: 0x0600F86A RID: 63594
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeMapper_UseVDWSpheresSettings_79(HandleRef pThis);

		/// <summary>
		/// Set ivars to default van der Waals spheres settings. This is
		/// equivalent to the following:
		/// - SetRenderAtoms( true )
		/// - SetRenderBonds( true )
		/// - SetAtomicRadiusType( VDWRadius )
		/// - SetAtomicRadiusScaleFactor( 1.0 )
		/// - SetBondColorMode( DiscreteByAtom )
		/// - SetUseMultiCylindersForBonds( true )
		/// - SetBondRadius( 0.075 )
		/// </summary>
		// Token: 0x0600F86B RID: 63595 RVA: 0x0015923C File Offset: 0x0015743C
		public void UseVDWSpheresSettings()
		{
			vtkMoleculeMapper.vtkMoleculeMapper_UseVDWSpheresSettings_79(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001203 RID: 4611
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001204 RID: 4612
		public new static readonly string MRClassNameKey = "class vtkMoleculeMapper";

		/// <summary>
		/// Get/Set whether or not to render the unit cell lattice, if present.
		/// Default: On.
		/// </summary>
		// Token: 0x02000578 RID: 1400
		public enum CovalentRadius_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001206 RID: 4614
			CovalentRadius,
			/// <summary>enum member</summary>
			// Token: 0x04001207 RID: 4615
			CustomArrayRadius = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001208 RID: 4616
			UnitRadius = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001209 RID: 4617
			VDWRadius = 1
		}

		/// <summary>
		/// Get/Set whether multicylinders will be used to represent multiple
		/// bonds. Default: On.
		/// </summary>
		// Token: 0x02000579 RID: 1401
		public enum DiscreteByAtom_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400120B RID: 4619
			DiscreteByAtom = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400120C RID: 4620
			SingleColor = 0
		}
	}
}
