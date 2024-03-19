using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridQuadricDecimation
	/// </summary>
	/// <remarks>
	///    reduce the number of
	/// tetrahedra in a mesh
	///
	///
	///
	/// vtkUnstructuredGridQuadricDecimation is a class that simplifies
	/// tetrahedral meshes using randomized multiple choice edge
	/// collapses. The input to this filter is a vtkUnstructuredGrid object
	/// with a single scalar field (specifying in the ScalarsName
	/// attribute). Users can determine the size of the output mesh by
	/// either setting the value of TargetReduction or
	/// NumberOfTetsOutput. The BoundaryWeight can be set to control how
	/// well the mesh boundary should be preserved. The implementation uses
	/// Michael Garland's generalized Quadric Error Metrics, the Corner
	/// Table representation and the Standard Conjugate Gradient Method to
	/// order the edge collapse sequence.
	///
	/// Instead of using the traditional priority queue, the algorithm uses
	/// a randomized approach to yield faster performance with comparable
	/// quality. At each step, a set of 8 random candidate edges are
	/// examined to select the best edge to collapse. This number can also
	/// be changed by users through NumberOfCandidates.
	///
	/// For more information as well as the streaming version of this
	/// algorithm see:
	///
	/// "Streaming Simplification of Tetrahedral Meshes" by H. T. Vo,
	/// S. P. Callahan, P. Lindstrom, V. Pascucci and C. T. Silva, IEEE
	/// Transactions on Visualization and Computer Graphics, 13(1):145-155,
	/// 2007.
	///
	///
	/// @par Acknowledgments:
	/// This code was developed by Huy T. Vo under the supervision of
	/// Prof. Claudio T. Silva. The code also contains contributions from
	/// Peter Lindstrom and Steven P. Callahan.
	///
	/// @par Acknowledgments:
	/// The work was supported by grants, contracts, and gifts from the
	/// National Science Foundation, the Department of Energy and IBM.
	/// </remarks>
	// Token: 0x020009BC RID: 2492
	public class vtkUnstructuredGridQuadricDecimation : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A0BB RID: 106683 RVA: 0x00241B0C File Offset: 0x0023FD0C
		static vtkUnstructuredGridQuadricDecimation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridQuadricDecimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridQuadricDecimation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A0BC RID: 106684 RVA: 0x00241B34 File Offset: 0x0023FD34
		public vtkUnstructuredGridQuadricDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A0BD RID: 106685
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0BE RID: 106686 RVA: 0x00241B44 File Offset: 0x0023FD44
		public new static vtkUnstructuredGridQuadricDecimation New()
		{
			vtkUnstructuredGridQuadricDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridQuadricDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0BF RID: 106687 RVA: 0x00241B98 File Offset: 0x0023FD98
		public vtkUnstructuredGridQuadricDecimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A0C0 RID: 106688 RVA: 0x00241BDC File Offset: 0x0023FDDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A0C1 RID: 106689
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidates_01(HandleRef pThis);

		/// <summary>
		/// Enable(1)/Disable(0) the feature of temporarily doubling the number of
		/// candidates for each randomized set if the quadric error was significantly
		/// increased over the last edge collapse, i.e. if the ratio between the error
		/// difference and the last error is over some threshold. Basically, we are
		/// trying to make up for cases when random selection returns so many 'bad'
		/// edges. By doing this we can achieve a higher quality output with much less
		/// time than just double the NumberOfCandidates. Default is Enabled(1)
		/// </summary>
		// Token: 0x0601A0C2 RID: 106690 RVA: 0x00241BE8 File Offset: 0x0023FDE8
		public virtual int GetAutoAddCandidates()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidates_01(base.GetCppThis());
		}

		// Token: 0x0601A0C3 RID: 106691
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidatesThreshold_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the threshold that decides when to double the set size.
		/// Default is 0.4.
		/// </summary>
		// Token: 0x0601A0C4 RID: 106692 RVA: 0x00241C08 File Offset: 0x0023FE08
		public virtual double GetAutoAddCandidatesThreshold()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetAutoAddCandidatesThreshold_02(base.GetCppThis());
		}

		// Token: 0x0601A0C5 RID: 106693
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnstructuredGridQuadricDecimation_GetBoundaryWeight_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the weight of the boundary on the quadric metrics. The larger
		/// the number, the better the boundary is preserved.
		/// </summary>
		// Token: 0x0601A0C6 RID: 106694 RVA: 0x00241C28 File Offset: 0x0023FE28
		public virtual double GetBoundaryWeight()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetBoundaryWeight_03(base.GetCppThis());
		}

		// Token: 0x0601A0C7 RID: 106695
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridQuadricDecimation_GetNumberOfCandidates_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of candidates selected for each randomized set before
		/// performing an edge collapse. Increasing this number can help producing
		/// higher quality output but it will be slower. Default is 8.
		/// </summary>
		// Token: 0x0601A0C8 RID: 106696 RVA: 0x00241C48 File Offset: 0x0023FE48
		public virtual int GetNumberOfCandidates()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetNumberOfCandidates_04(base.GetCppThis());
		}

		// Token: 0x0601A0C9 RID: 106697
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridQuadricDecimation_GetNumberOfEdgesToDecimate_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired number of edge to collapse
		/// </summary>
		// Token: 0x0601A0CA RID: 106698 RVA: 0x00241C68 File Offset: 0x0023FE68
		public virtual int GetNumberOfEdgesToDecimate()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetNumberOfEdgesToDecimate_05(base.GetCppThis());
		}

		// Token: 0x0601A0CB RID: 106699
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0CC RID: 106700 RVA: 0x00241C88 File Offset: 0x0023FE88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A0CD RID: 106701
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0CE RID: 106702 RVA: 0x00241CA8 File Offset: 0x0023FEA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601A0CF RID: 106703
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridQuadricDecimation_GetNumberOfTetsOutput_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired number of tetrahedra to be outputted
		/// </summary>
		// Token: 0x0601A0D0 RID: 106704 RVA: 0x00241CC4 File Offset: 0x0023FEC4
		public virtual int GetNumberOfTetsOutput()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetNumberOfTetsOutput_08(base.GetCppThis());
		}

		// Token: 0x0601A0D1 RID: 106705
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_GetScalarsName_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the scalar field name used for simplification
		/// </summary>
		// Token: 0x0601A0D2 RID: 106706 RVA: 0x00241CE4 File Offset: 0x0023FEE4
		public virtual string GetScalarsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetScalarsName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601A0D3 RID: 106707
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnstructuredGridQuadricDecimation_GetTargetReduction_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired reduction (expressed as a fraction of the original
		/// number of tetrehedra)
		/// </summary>
		// Token: 0x0601A0D4 RID: 106708 RVA: 0x00241D20 File Offset: 0x0023FF20
		public virtual double GetTargetReduction()
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_GetTargetReduction_10(base.GetCppThis());
		}

		// Token: 0x0601A0D5 RID: 106709
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridQuadricDecimation_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0D6 RID: 106710 RVA: 0x00241D40 File Offset: 0x0023FF40
		public override int IsA(string type)
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601A0D7 RID: 106711
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridQuadricDecimation_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0D8 RID: 106712 RVA: 0x00241D60 File Offset: 0x0023FF60
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_IsTypeOf_12(type);
		}

		// Token: 0x0601A0D9 RID: 106713
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0DA RID: 106714 RVA: 0x00241D7C File Offset: 0x0023FF7C
		public new vtkUnstructuredGridQuadricDecimation NewInstance()
		{
			vtkUnstructuredGridQuadricDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridQuadricDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A0DB RID: 106715
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridQuadricDecimation_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0DC RID: 106716 RVA: 0x00241DD8 File Offset: 0x0023FFD8
		public new static vtkUnstructuredGridQuadricDecimation SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridQuadricDecimation vtkUnstructuredGridQuadricDecimation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridQuadricDecimation = (vtkUnstructuredGridQuadricDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridQuadricDecimation.Register(null);
				}
			}
			return vtkUnstructuredGridQuadricDecimation;
		}

		// Token: 0x0601A0DD RID: 106717
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidates_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable(1)/Disable(0) the feature of temporarily doubling the number of
		/// candidates for each randomized set if the quadric error was significantly
		/// increased over the last edge collapse, i.e. if the ratio between the error
		/// difference and the last error is over some threshold. Basically, we are
		/// trying to make up for cases when random selection returns so many 'bad'
		/// edges. By doing this we can achieve a higher quality output with much less
		/// time than just double the NumberOfCandidates. Default is Enabled(1)
		/// </summary>
		// Token: 0x0601A0DE RID: 106718 RVA: 0x00241E57 File Offset: 0x00240057
		public virtual void SetAutoAddCandidates(int _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidates_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0DF RID: 106719
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidatesThreshold_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the threshold that decides when to double the set size.
		/// Default is 0.4.
		/// </summary>
		// Token: 0x0601A0E0 RID: 106720 RVA: 0x00241E67 File Offset: 0x00240067
		public virtual void SetAutoAddCandidatesThreshold(double _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetAutoAddCandidatesThreshold_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0E1 RID: 106721
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetBoundaryWeight_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the weight of the boundary on the quadric metrics. The larger
		/// the number, the better the boundary is preserved.
		/// </summary>
		// Token: 0x0601A0E2 RID: 106722 RVA: 0x00241E77 File Offset: 0x00240077
		public virtual void SetBoundaryWeight(double _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetBoundaryWeight_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0E3 RID: 106723
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetNumberOfCandidates_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of candidates selected for each randomized set before
		/// performing an edge collapse. Increasing this number can help producing
		/// higher quality output but it will be slower. Default is 8.
		/// </summary>
		// Token: 0x0601A0E4 RID: 106724 RVA: 0x00241E87 File Offset: 0x00240087
		public virtual void SetNumberOfCandidates(int _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetNumberOfCandidates_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0E5 RID: 106725
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetNumberOfEdgesToDecimate_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the desired number of edge to collapse
		/// </summary>
		// Token: 0x0601A0E6 RID: 106726 RVA: 0x00241E97 File Offset: 0x00240097
		public virtual void SetNumberOfEdgesToDecimate(int _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetNumberOfEdgesToDecimate_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0E7 RID: 106727
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetNumberOfTetsOutput_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the desired number of tetrahedra to be outputted
		/// </summary>
		// Token: 0x0601A0E8 RID: 106728 RVA: 0x00241EA7 File Offset: 0x002400A7
		public virtual void SetNumberOfTetsOutput(int _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetNumberOfTetsOutput_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0E9 RID: 106729
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetScalarsName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the scalar field name used for simplification
		/// </summary>
		// Token: 0x0601A0EA RID: 106730 RVA: 0x00241EB7 File Offset: 0x002400B7
		public virtual void SetScalarsName(string _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetScalarsName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0EB RID: 106731
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridQuadricDecimation_SetTargetReduction_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the desired reduction (expressed as a fraction of the original
		/// number of tetrehedra)
		/// </summary>
		// Token: 0x0601A0EC RID: 106732 RVA: 0x00241EC7 File Offset: 0x002400C7
		public virtual void SetTargetReduction(double _arg)
		{
			vtkUnstructuredGridQuadricDecimation.vtkUnstructuredGridQuadricDecimation_SetTargetReduction_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C3E RID: 7230
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridQuadricDecimation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C3F RID: 7231
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridQuadricDecimation";

		/// <summary>
		/// Set/Get the scalar field name used for simplification
		/// </summary>
		// Token: 0x020009BD RID: 2493
		public enum NON_ERROR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C41 RID: 7233
			NON_ERROR,
			/// <summary>enum member</summary>
			// Token: 0x04001C42 RID: 7234
			NON_TETRAHEDRA,
			/// <summary>enum member</summary>
			// Token: 0x04001C43 RID: 7235
			NO_CELLS = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001C44 RID: 7236
			NO_SCALARS = 2
		}
	}
}
