using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalPathLineFilter
	/// </summary>
	/// <remarks>
	///    Generate a Polydata Pointset from any Dataset.
	///
	///
	/// vtkTemporalPathLineFilter takes any dataset as input, it extracts the point
	/// locations of all cells over time to build up a polyline trail.
	/// The point number (index) is used as the 'key' if the points are randomly
	/// changing their respective order in the points list, then you should specify
	/// a scalar that represents the unique ID. This is intended to handle the output
	/// of a filter such as the vtkParticleTracer.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParticleTracer
	///
	/// @par Thanks:
	/// John Bidiscombe of
	/// CSCS - Swiss National Supercomputing Centre
	/// for creating and contributing this class.
	/// </seealso>
	// Token: 0x020008EF RID: 2287
	public class vtkTemporalPathLineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060179FB RID: 96763 RVA: 0x002120BF File Offset: 0x002102BF
		static vtkTemporalPathLineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalPathLineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalPathLineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060179FC RID: 96764 RVA: 0x002120E7 File Offset: 0x002102E7
		public vtkTemporalPathLineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060179FD RID: 96765
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalPathLineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x060179FE RID: 96766 RVA: 0x002120F8 File Offset: 0x002102F8
		public new static vtkTemporalPathLineFilter New()
		{
			vtkTemporalPathLineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x060179FF RID: 96767 RVA: 0x0021214C File Offset: 0x0021034C
		public vtkTemporalPathLineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017A00 RID: 96768 RVA: 0x00212190 File Offset: 0x00210390
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017A01 RID: 96769
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_Flush_01(HandleRef pThis);

		/// <summary>
		/// Flush will wipe any existing data so that traces can be restarted from
		/// whatever time step is next supplied.
		/// </summary>
		// Token: 0x06017A02 RID: 96770 RVA: 0x0021219B File Offset: 0x0021039B
		public void Flush()
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_Flush_01(base.GetCppThis());
		}

		// Token: 0x06017A03 RID: 96771
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalPathLineFilter_GetIdChannelArray_02(HandleRef pThis);

		/// <summary>
		/// Specify the name of a scalar array which will be used to fetch
		/// the index of each point. This is necessary only if the particles
		/// change position (Id order) on each time step. The Id can be used
		/// to identify particles at each step and hence track them properly.
		/// If this array is nullptr, the global point ids are used.  If an Id
		/// array cannot otherwise be found, the point index is used as the ID.
		/// </summary>
		// Token: 0x06017A04 RID: 96772 RVA: 0x002121AC File Offset: 0x002103AC
		public virtual string GetIdChannelArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetIdChannelArray_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017A05 RID: 96773
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalPathLineFilter_GetKeepDeadTrails_03(HandleRef pThis);

		/// <summary>
		/// When a particle 'disappears', the trail belonging to it is removed from
		/// the list. When this flag is enabled, dead trails will persist
		/// until the next time the list is cleared. Use carefully as it may cause
		/// excessive memory consumption if left on by mistake.
		/// </summary>
		// Token: 0x06017A06 RID: 96774 RVA: 0x002121E8 File Offset: 0x002103E8
		public virtual bool GetKeepDeadTrails()
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetKeepDeadTrails_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06017A07 RID: 96775
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalPathLineFilter_GetMaskPoints_04(HandleRef pThis);

		/// <summary>
		/// Set the number of particles to track as a ratio of the input
		/// example: setting MaskPoints to 10 will track every 10th point
		/// </summary>
		// Token: 0x06017A08 RID: 96776 RVA: 0x00212210 File Offset: 0x00210410
		public virtual int GetMaskPoints()
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaskPoints_04(base.GetCppThis());
		}

		// Token: 0x06017A09 RID: 96777
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalPathLineFilter_GetMaxStepDistance_05(HandleRef pThis);

		/// <summary>
		/// If a particle disappears from one end of a simulation and reappears
		/// on the other side, the track left will be unrepresentative.
		/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
		/// if a step occurs larger than the value (for the dimension), the track will
		/// be dropped and restarted after the step. (ie the part before the wrap
		/// around will be dropped and the newer part kept).
		/// </summary>
		// Token: 0x06017A0A RID: 96778 RVA: 0x00212230 File Offset: 0x00210430
		public virtual double[] GetMaxStepDistance()
		{
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxStepDistance_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017A0B RID: 96779
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_GetMaxStepDistance_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// If a particle disappears from one end of a simulation and reappears
		/// on the other side, the track left will be unrepresentative.
		/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
		/// if a step occurs larger than the value (for the dimension), the track will
		/// be dropped and restarted after the step. (ie the part before the wrap
		/// around will be dropped and the newer part kept).
		/// </summary>
		// Token: 0x06017A0C RID: 96780 RVA: 0x00212278 File Offset: 0x00210478
		public virtual void GetMaxStepDistance(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxStepDistance_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06017A0D RID: 96781
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_GetMaxStepDistance_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If a particle disappears from one end of a simulation and reappears
		/// on the other side, the track left will be unrepresentative.
		/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
		/// if a step occurs larger than the value (for the dimension), the track will
		/// be dropped and restarted after the step. (ie the part before the wrap
		/// around will be dropped and the newer part kept).
		/// </summary>
		// Token: 0x06017A0E RID: 96782 RVA: 0x0021228A File Offset: 0x0021048A
		public virtual void GetMaxStepDistance(IntPtr _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxStepDistance_07(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A0F RID: 96783
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkTemporalPathLineFilter_GetMaxTrackLength_08(HandleRef pThis);

		/// <summary>
		/// If the Particles being traced animate for a long time, the
		/// trails or traces will become long and stringy. Setting
		/// the MaxTraceTimeLength will limit how much of the trace
		/// is displayed. Tracks longer then the Max will disappear
		/// and the trace will appear like a snake of fixed length
		/// which progresses as the particle moves
		/// </summary>
		// Token: 0x06017A10 RID: 96784 RVA: 0x0021229C File Offset: 0x0021049C
		public virtual uint GetMaxTrackLength()
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetMaxTrackLength_08(base.GetCppThis());
		}

		// Token: 0x06017A11 RID: 96785
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06017A12 RID: 96786 RVA: 0x002122BC File Offset: 0x002104BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06017A13 RID: 96787
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06017A14 RID: 96788 RVA: 0x002122DC File Offset: 0x002104DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06017A15 RID: 96789
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalPathLineFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06017A16 RID: 96790 RVA: 0x002122F8 File Offset: 0x002104F8
		public override int IsA(string type)
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06017A17 RID: 96791
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalPathLineFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06017A18 RID: 96792 RVA: 0x00212318 File Offset: 0x00210518
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_IsTypeOf_12(type);
		}

		// Token: 0x06017A19 RID: 96793
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalPathLineFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06017A1A RID: 96794 RVA: 0x00212334 File Offset: 0x00210534
		public new vtkTemporalPathLineFilter NewInstance()
		{
			vtkTemporalPathLineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017A1B RID: 96795
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalPathLineFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06017A1C RID: 96796 RVA: 0x00212390 File Offset: 0x00210590
		public new static vtkTemporalPathLineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalPathLineFilter vtkTemporalPathLineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalPathLineFilter = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalPathLineFilter.Register(null);
				}
			}
			return vtkTemporalPathLineFilter;
		}

		// Token: 0x06017A1D RID: 96797
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetIdChannelArray_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of a scalar array which will be used to fetch
		/// the index of each point. This is necessary only if the particles
		/// change position (Id order) on each time step. The Id can be used
		/// to identify particles at each step and hence track them properly.
		/// If this array is nullptr, the global point ids are used.  If an Id
		/// array cannot otherwise be found, the point index is used as the ID.
		/// </summary>
		// Token: 0x06017A1E RID: 96798 RVA: 0x0021240F File Offset: 0x0021060F
		public virtual void SetIdChannelArray(string _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetIdChannelArray_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A1F RID: 96799
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetKeepDeadTrails_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// When a particle 'disappears', the trail belonging to it is removed from
		/// the list. When this flag is enabled, dead trails will persist
		/// until the next time the list is cleared. Use carefully as it may cause
		/// excessive memory consumption if left on by mistake.
		/// </summary>
		// Token: 0x06017A20 RID: 96800 RVA: 0x0021241F File Offset: 0x0021061F
		public virtual void SetKeepDeadTrails(bool _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetKeepDeadTrails_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017A21 RID: 96801
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetMaskPoints_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of particles to track as a ratio of the input
		/// example: setting MaskPoints to 10 will track every 10th point
		/// </summary>
		// Token: 0x06017A22 RID: 96802 RVA: 0x00212437 File Offset: 0x00210637
		public virtual void SetMaskPoints(int _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaskPoints_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A23 RID: 96803
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetMaxStepDistance_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// If a particle disappears from one end of a simulation and reappears
		/// on the other side, the track left will be unrepresentative.
		/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
		/// if a step occurs larger than the value (for the dimension), the track will
		/// be dropped and restarted after the step. (ie the part before the wrap
		/// around will be dropped and the newer part kept).
		/// </summary>
		// Token: 0x06017A24 RID: 96804 RVA: 0x00212447 File Offset: 0x00210647
		public virtual void SetMaxStepDistance(double _arg1, double _arg2, double _arg3)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaxStepDistance_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06017A25 RID: 96805
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetMaxStepDistance_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If a particle disappears from one end of a simulation and reappears
		/// on the other side, the track left will be unrepresentative.
		/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
		/// if a step occurs larger than the value (for the dimension), the track will
		/// be dropped and restarted after the step. (ie the part before the wrap
		/// around will be dropped and the newer part kept).
		/// </summary>
		// Token: 0x06017A26 RID: 96806 RVA: 0x00212459 File Offset: 0x00210659
		public virtual void SetMaxStepDistance(IntPtr _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaxStepDistance_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A27 RID: 96807
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetMaxTrackLength_21(HandleRef pThis, uint _arg);

		/// <summary>
		/// If the Particles being traced animate for a long time, the
		/// trails or traces will become long and stringy. Setting
		/// the MaxTraceTimeLength will limit how much of the trace
		/// is displayed. Tracks longer then the Max will disappear
		/// and the trace will appear like a snake of fixed length
		/// which progresses as the particle moves
		/// </summary>
		// Token: 0x06017A28 RID: 96808 RVA: 0x00212469 File Offset: 0x00210669
		public virtual void SetMaxTrackLength(uint _arg)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetMaxTrackLength_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A29 RID: 96809
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetSelectionConnection_22(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set a second input which is a selection. Particles with the same
		/// Id in the selection as the primary input will be chosen for pathlines
		/// Note that you must have the same IdChannelArray in the selection as the input
		/// </summary>
		// Token: 0x06017A2A RID: 96810 RVA: 0x0021247C File Offset: 0x0021067C
		public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetSelectionConnection_22(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06017A2B RID: 96811
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalPathLineFilter_SetSelectionData_23(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set a second input which is a selection. Particles with the same
		/// Id in the selection as the primary input will be chosen for pathlines
		/// Note that you must have the same IdChannelArray in the selection as the input
		/// </summary>
		// Token: 0x06017A2C RID: 96812 RVA: 0x002124AC File Offset: 0x002106AC
		public void SetSelectionData(vtkDataSet input)
		{
			vtkTemporalPathLineFilter.vtkTemporalPathLineFilter_SetSelectionData_23(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A5D RID: 6749
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalPathLineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A5E RID: 6750
		public new static readonly string MRClassNameKey = "class vtkTemporalPathLineFilter";
	}
}
