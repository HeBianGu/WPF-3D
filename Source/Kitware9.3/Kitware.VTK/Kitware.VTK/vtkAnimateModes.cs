using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkAnimateModes
	/// </summary>
	/// <remarks>
	///  animate mode shapes
	///
	/// For certain file formats, like Exodus, simulation codes may use the timesteps
	/// and time values to represent quantities other than time. For example, for
	/// modal analysis, the natural frequency for each mode may be used as the time
	/// value. vtkAnimateModes can be used to reinterpret time as mode shapes.
	/// The filter can also animate vibrations for each mode shape (when
	/// AnimateVibrations is set to true). In that case, the time requested by the
	/// downstream pipeline is used to scale the displacement magnitude
	/// for a mode shape in a sinusoidal pattern, `cos(2*pi * requested-time)`.
	///
	/// Historically, the VTK's Exodus reader (`vtkExodusIIReader`) had support for
	/// this internally. However, when implementation the IOSS-based reader for
	/// Exodus files (`vtkIossReader`), it was decided that it's cleaner to leave the
	/// mode shape and vibration animation logic independent of the reader and thus
	/// make it usable with other file formats too. Hence this filter was created.
	/// </remarks>
	// Token: 0x0200086D RID: 2157
	public class vtkAnimateModes : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601665E RID: 91742 RVA: 0x001F7C79 File Offset: 0x001F5E79
		static vtkAnimateModes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnimateModes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimateModes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601665F RID: 91743 RVA: 0x001F7CA1 File Offset: 0x001F5EA1
		public vtkAnimateModes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016660 RID: 91744
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimateModes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016661 RID: 91745 RVA: 0x001F7CB0 File Offset: 0x001F5EB0
		public new static vtkAnimateModes New()
		{
			vtkAnimateModes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimateModes.vtkAnimateModes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimateModes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016662 RID: 91746 RVA: 0x001F7D04 File Offset: 0x001F5F04
		public vtkAnimateModes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnimateModes.vtkAnimateModes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016663 RID: 91747 RVA: 0x001F7D48 File Offset: 0x001F5F48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016664 RID: 91748
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_AnimateVibrationsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the filter should animate the vibrations.
		/// Defaults to true. When set, the requested time is used compute
		/// displacements for the chosen mode shape.
		/// Defaults to true.
		/// </summary>
		// Token: 0x06016665 RID: 91749 RVA: 0x001F7D53 File Offset: 0x001F5F53
		public virtual void AnimateVibrationsOff()
		{
			vtkAnimateModes.vtkAnimateModes_AnimateVibrationsOff_01(base.GetCppThis());
		}

		// Token: 0x06016666 RID: 91750
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_AnimateVibrationsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the filter should animate the vibrations.
		/// Defaults to true. When set, the requested time is used compute
		/// displacements for the chosen mode shape.
		/// Defaults to true.
		/// </summary>
		// Token: 0x06016667 RID: 91751 RVA: 0x001F7D62 File Offset: 0x001F5F62
		public virtual void AnimateVibrationsOn()
		{
			vtkAnimateModes.vtkAnimateModes_AnimateVibrationsOn_02(base.GetCppThis());
		}

		// Token: 0x06016668 RID: 91752
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_DisplacementPreappliedOff_03(HandleRef pThis);

		/// <summary>
		/// Get/Set whether displacements are pre-applied.
		/// Default is false.
		/// </summary>
		// Token: 0x06016669 RID: 91753 RVA: 0x001F7D71 File Offset: 0x001F5F71
		public virtual void DisplacementPreappliedOff()
		{
			vtkAnimateModes.vtkAnimateModes_DisplacementPreappliedOff_03(base.GetCppThis());
		}

		// Token: 0x0601666A RID: 91754
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_DisplacementPreappliedOn_04(HandleRef pThis);

		/// <summary>
		/// Get/Set whether displacements are pre-applied.
		/// Default is false.
		/// </summary>
		// Token: 0x0601666B RID: 91755 RVA: 0x001F7D80 File Offset: 0x001F5F80
		public virtual void DisplacementPreappliedOn()
		{
			vtkAnimateModes.vtkAnimateModes_DisplacementPreappliedOn_04(base.GetCppThis());
		}

		// Token: 0x0601666C RID: 91756
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAnimateModes_GetAnimateVibrations_05(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the filter should animate the vibrations.
		/// Defaults to true. When set, the requested time is used compute
		/// displacements for the chosen mode shape.
		/// Defaults to true.
		/// </summary>
		// Token: 0x0601666D RID: 91757 RVA: 0x001F7D90 File Offset: 0x001F5F90
		public virtual bool GetAnimateVibrations()
		{
			return vtkAnimateModes.vtkAnimateModes_GetAnimateVibrations_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601666E RID: 91758
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimateModes_GetDisplacementMagnitude_06(HandleRef pThis);

		/// <summary>
		/// Get/Set a scale factor to apply the displacements.
		/// Defaults to 1.
		/// </summary>
		// Token: 0x0601666F RID: 91759 RVA: 0x001F7DB8 File Offset: 0x001F5FB8
		public virtual double GetDisplacementMagnitude()
		{
			return vtkAnimateModes.vtkAnimateModes_GetDisplacementMagnitude_06(base.GetCppThis());
		}

		// Token: 0x06016670 RID: 91760
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAnimateModes_GetDisplacementPreapplied_07(HandleRef pThis);

		/// <summary>
		/// Get/Set whether displacements are pre-applied.
		/// Default is false.
		/// </summary>
		// Token: 0x06016671 RID: 91761 RVA: 0x001F7DD8 File Offset: 0x001F5FD8
		public virtual bool GetDisplacementPreapplied()
		{
			return vtkAnimateModes.vtkAnimateModes_GetDisplacementPreapplied_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06016672 RID: 91762
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimateModes_GetModeShape_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode shape to animate. Defaults to 1.
		/// </summary>
		// Token: 0x06016673 RID: 91763 RVA: 0x001F7E00 File Offset: 0x001F6000
		public virtual int GetModeShape()
		{
			return vtkAnimateModes.vtkAnimateModes_GetModeShape_08(base.GetCppThis());
		}

		// Token: 0x06016674 RID: 91764
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimateModes_GetModeShapeMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode shape to animate. Defaults to 1.
		/// </summary>
		// Token: 0x06016675 RID: 91765 RVA: 0x001F7E20 File Offset: 0x001F6020
		public virtual int GetModeShapeMaxValue()
		{
			return vtkAnimateModes.vtkAnimateModes_GetModeShapeMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06016676 RID: 91766
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimateModes_GetModeShapeMinValue_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the mode shape to animate. Defaults to 1.
		/// </summary>
		// Token: 0x06016677 RID: 91767 RVA: 0x001F7E40 File Offset: 0x001F6040
		public virtual int GetModeShapeMinValue()
		{
			return vtkAnimateModes.vtkAnimateModes_GetModeShapeMinValue_10(base.GetCppThis());
		}

		// Token: 0x06016678 RID: 91768
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimateModes_GetModeShapesRange_11(HandleRef pThis);

		/// <summary>
		/// Get the range for available mode shapes in the input. One must call
		/// `UpdateInformation` before check the range since the range is determined
		/// based on the number of input timesteps. The range is always `[1, &lt;number of
		/// timesteps&gt;]`.
		/// </summary>
		// Token: 0x06016679 RID: 91769 RVA: 0x001F7E60 File Offset: 0x001F6060
		public virtual int[] GetModeShapesRange()
		{
			IntPtr intPtr = vtkAnimateModes.vtkAnimateModes_GetModeShapesRange_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601667A RID: 91770
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_GetModeShapesRange_12(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the range for available mode shapes in the input. One must call
		/// `UpdateInformation` before check the range since the range is determined
		/// based on the number of input timesteps. The range is always `[1, &lt;number of
		/// timesteps&gt;]`.
		/// </summary>
		// Token: 0x0601667B RID: 91771 RVA: 0x001F7EA8 File Offset: 0x001F60A8
		public virtual void GetModeShapesRange(ref int _arg1, ref int _arg2)
		{
			vtkAnimateModes.vtkAnimateModes_GetModeShapesRange_12(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0601667C RID: 91772
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_GetModeShapesRange_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the range for available mode shapes in the input. One must call
		/// `UpdateInformation` before check the range since the range is determined
		/// based on the number of input timesteps. The range is always `[1, &lt;number of
		/// timesteps&gt;]`.
		/// </summary>
		// Token: 0x0601667D RID: 91773 RVA: 0x001F7EB9 File Offset: 0x001F60B9
		public virtual void GetModeShapesRange(IntPtr _arg)
		{
			vtkAnimateModes.vtkAnimateModes_GetModeShapesRange_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601667E RID: 91774
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnimateModes_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601667F RID: 91775 RVA: 0x001F7ECC File Offset: 0x001F60CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnimateModes.vtkAnimateModes_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06016680 RID: 91776
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnimateModes_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016681 RID: 91777 RVA: 0x001F7EEC File Offset: 0x001F60EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnimateModes.vtkAnimateModes_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06016682 RID: 91778
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimateModes_GetTimeRange_16(HandleRef pThis);

		/// <summary>
		/// This returns (0, 1.0) as the range that can be used when animating a mode
		/// shape.
		/// </summary>
		// Token: 0x06016683 RID: 91779 RVA: 0x001F7F08 File Offset: 0x001F6108
		public virtual double[] GetTimeRange()
		{
			IntPtr intPtr = vtkAnimateModes.vtkAnimateModes_GetTimeRange_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016684 RID: 91780
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_GetTimeRange_17(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// This returns (0, 1.0) as the range that can be used when animating a mode
		/// shape.
		/// </summary>
		// Token: 0x06016685 RID: 91781 RVA: 0x001F7F50 File Offset: 0x001F6150
		public virtual void GetTimeRange(ref double _arg1, ref double _arg2)
		{
			vtkAnimateModes.vtkAnimateModes_GetTimeRange_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06016686 RID: 91782
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_GetTimeRange_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This returns (0, 1.0) as the range that can be used when animating a mode
		/// shape.
		/// </summary>
		// Token: 0x06016687 RID: 91783 RVA: 0x001F7F61 File Offset: 0x001F6161
		public virtual void GetTimeRange(IntPtr _arg)
		{
			vtkAnimateModes.vtkAnimateModes_GetTimeRange_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06016688 RID: 91784
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimateModes_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016689 RID: 91785 RVA: 0x001F7F74 File Offset: 0x001F6174
		public override int IsA(string type)
		{
			return vtkAnimateModes.vtkAnimateModes_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0601668A RID: 91786
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimateModes_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601668B RID: 91787 RVA: 0x001F7F94 File Offset: 0x001F6194
		public new static int IsTypeOf(string type)
		{
			return vtkAnimateModes.vtkAnimateModes_IsTypeOf_20(type);
		}

		// Token: 0x0601668C RID: 91788
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimateModes_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601668D RID: 91789 RVA: 0x001F7FB0 File Offset: 0x001F61B0
		public new vtkAnimateModes NewInstance()
		{
			vtkAnimateModes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimateModes.vtkAnimateModes_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimateModes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601668E RID: 91790
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimateModes_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601668F RID: 91791 RVA: 0x001F800C File Offset: 0x001F620C
		public new static vtkAnimateModes SafeDownCast(vtkObjectBase o)
		{
			vtkAnimateModes vtkAnimateModes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimateModes.vtkAnimateModes_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnimateModes = (vtkAnimateModes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnimateModes.Register(null);
				}
			}
			return vtkAnimateModes;
		}

		// Token: 0x06016690 RID: 91792
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_SetAnimateVibrations_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether the filter should animate the vibrations.
		/// Defaults to true. When set, the requested time is used compute
		/// displacements for the chosen mode shape.
		/// Defaults to true.
		/// </summary>
		// Token: 0x06016691 RID: 91793 RVA: 0x001F808B File Offset: 0x001F628B
		public virtual void SetAnimateVibrations(bool _arg)
		{
			vtkAnimateModes.vtkAnimateModes_SetAnimateVibrations_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016692 RID: 91794
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_SetDisplacementMagnitude_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set a scale factor to apply the displacements.
		/// Defaults to 1.
		/// </summary>
		// Token: 0x06016693 RID: 91795 RVA: 0x001F80A3 File Offset: 0x001F62A3
		public virtual void SetDisplacementMagnitude(double _arg)
		{
			vtkAnimateModes.vtkAnimateModes_SetDisplacementMagnitude_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06016694 RID: 91796
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_SetDisplacementPreapplied_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether displacements are pre-applied.
		/// Default is false.
		/// </summary>
		// Token: 0x06016695 RID: 91797 RVA: 0x001F80B3 File Offset: 0x001F62B3
		public virtual void SetDisplacementPreapplied(bool _arg)
		{
			vtkAnimateModes.vtkAnimateModes_SetDisplacementPreapplied_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016696 RID: 91798
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimateModes_SetModeShape_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the mode shape to animate. Defaults to 1.
		/// </summary>
		// Token: 0x06016697 RID: 91799 RVA: 0x001F80CB File Offset: 0x001F62CB
		public virtual void SetModeShape(int _arg)
		{
			vtkAnimateModes.vtkAnimateModes_SetModeShape_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001930 RID: 6448
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnimateModes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001931 RID: 6449
		public new static readonly string MRClassNameKey = "class vtkAnimateModes";
	}
}
