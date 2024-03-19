using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSelectPolyData
	/// </summary>
	/// <remarks>
	///    select portion of polygonal mesh; generate selection scalars
	///
	/// vtkSelectPolyData is a filter that selects polygonal data based on
	/// defining a "loop" and indicating the region inside of the loop. The
	/// mesh within the loop consists of complete cells (the cells are not
	/// cut). Alternatively, this filter can be used to generate scalars.
	/// These scalar values, which are a distance measure to the loop, can
	/// be used to clip, contour. or extract data (i.e., anything that an
	/// implicit function can do).
	///
	/// The loop is defined by an array of x-y-z point coordinates.
	/// (Coordinates should be in the same coordinate space as the input
	/// polygonal data.) The loop can be concave and non-planar, but not
	/// self-intersecting. The input to the filter is a polygonal mesh
	/// (only surface primitives such as triangle strips and polygons); the
	/// output is either a) a portion of the original mesh laying within
	/// the selection loop (GenerateSelectionScalarsOff); or b) the same
	/// polygonal mesh with the addition of scalar values
	/// (GenerateSelectionScalarsOn).
	///
	/// The algorithm works as follows. For each point coordinate in the
	/// loop, the closest point in the mesh is found. The result is a loop
	/// of closest point ids from the mesh. Then, the edges in the mesh
	/// connecting the closest points (and laying along the lines forming
	/// the loop) are found. Edges between the points can be searched using
	/// one of these methods:
	/// A) Greedy edge tracking.
	/// At the current point, the mesh edge oriented in the
	/// direction of and whose end point is closest to the line is
	/// chosen. The edge is followed to the new end point, and the
	/// procedure is repeated. This process continues until the entire loop
	/// has been created. This method is simple and fast but heuristic,
	/// and edge search can randomly fail ("Can't follow edge" error)
	/// even for simple, flawless meshes when edge search arrives to a point
	/// from where there is no edge pointing towards the next loop point.
	/// B) Dijkstra shortest path. This method guarantees to find the shortest
	/// path between the loop points.
	///
	/// By default the greedy edge tracking method is used to preserve
	/// backward compatibility, but generally the Dijkstra shortest path
	/// method is recommended due to its robustness.
	///
	/// To determine what portion of the mesh is inside and outside of the
	/// loop, three options are possible. 1) the smallest connected region,
	/// 2) the largest connected region, and 3) the connected region
	/// closest to a user specified point. (Set the ivar SelectionMode.)
	///
	/// Once the loop is computed as above, the GenerateSelectionScalars
	/// controls the output of the filter. If on, then scalar values are
	/// generated based on distance to the loop lines. Otherwise, the cells
	/// laying inside the selection loop are output. By default, the mesh
	/// laying within the loop is output; however, if InsideOut is on, then
	/// the portion of the mesh laying outside of the loop is output.
	///
	/// The filter can be configured to generate the unselected portions of
	/// the mesh as output by setting GenerateUnselectedOutput. Use the
	/// method GetUnselectedOutput to access this output. (Note: this flag
	/// is pertinent only when GenerateSelectionScalars is off.)
	///
	/// @warning
	/// Make sure that the points you pick are on a connected surface. If
	/// not, then the filter will generate an empty or partial result. Also,
	/// self-intersecting loops will generate unpredictable results.
	///
	/// @warning
	/// During processing of the data, non-triangular cells are converted to
	/// triangles if GenerateSelectionScalars is off.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitSelectionLoop
	/// </seealso>
	// Token: 0x0200056F RID: 1391
	public class vtkSelectPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F69C RID: 63132 RVA: 0x00156D47 File Offset: 0x00154F47
		static vtkSelectPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F69D RID: 63133 RVA: 0x00156D6F File Offset: 0x00154F6F
		public vtkSelectPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F69E RID: 63134
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F69F RID: 63135 RVA: 0x00156D80 File Offset: 0x00154F80
		public new static vtkSelectPolyData New()
		{
			vtkSelectPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6A0 RID: 63136 RVA: 0x00156DD4 File Offset: 0x00154FD4
		public vtkSelectPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSelectPolyData.vtkSelectPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F6A1 RID: 63137 RVA: 0x00156E18 File Offset: 0x00155018
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F6A2 RID: 63138
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_GenerateSelectionScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag to control behavior of the filter. If
		/// GenerateSelectionScalars is on, then the output of the filter
		/// is the same as the input, except that scalars are generated.
		/// If off, the filter outputs the cells laying inside the loop, and
		/// does not generate scalars.
		/// </summary>
		// Token: 0x0600F6A3 RID: 63139 RVA: 0x00156E23 File Offset: 0x00155023
		public virtual void GenerateSelectionScalarsOff()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateSelectionScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x0600F6A4 RID: 63140
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_GenerateSelectionScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag to control behavior of the filter. If
		/// GenerateSelectionScalars is on, then the output of the filter
		/// is the same as the input, except that scalars are generated.
		/// If off, the filter outputs the cells laying inside the loop, and
		/// does not generate scalars.
		/// </summary>
		// Token: 0x0600F6A5 RID: 63141 RVA: 0x00156E32 File Offset: 0x00155032
		public virtual void GenerateSelectionScalarsOn()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateSelectionScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x0600F6A6 RID: 63142
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_GenerateUnselectedOutputOff_03(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's not been selected.
		/// </summary>
		// Token: 0x0600F6A7 RID: 63143 RVA: 0x00156E41 File Offset: 0x00155041
		public virtual void GenerateUnselectedOutputOff()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateUnselectedOutputOff_03(base.GetCppThis());
		}

		// Token: 0x0600F6A8 RID: 63144
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_GenerateUnselectedOutputOn_04(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's not been selected.
		/// </summary>
		// Token: 0x0600F6A9 RID: 63145 RVA: 0x00156E50 File Offset: 0x00155050
		public virtual void GenerateUnselectedOutputOn()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateUnselectedOutputOn_04(base.GetCppThis());
		}

		// Token: 0x0600F6AA RID: 63146
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetClosestPoint_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the point used in SelectionModeToClosestPointRegion.
		/// </summary>
		// Token: 0x0600F6AB RID: 63147 RVA: 0x00156E60 File Offset: 0x00155060
		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetClosestPoint_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F6AC RID: 63148
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_GetClosestPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the point used in SelectionModeToClosestPointRegion.
		/// </summary>
		// Token: 0x0600F6AD RID: 63149 RVA: 0x00156EA8 File Offset: 0x001550A8
		public virtual void GetClosestPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSelectPolyData.vtkSelectPolyData_GetClosestPoint_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F6AE RID: 63150
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_GetClosestPoint_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the point used in SelectionModeToClosestPointRegion.
		/// </summary>
		// Token: 0x0600F6AF RID: 63151 RVA: 0x00156EBA File Offset: 0x001550BA
		public virtual void GetClosestPoint(IntPtr _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_GetClosestPoint_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6B0 RID: 63152
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetEdgeSearchMode_08(HandleRef pThis);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6B1 RID: 63153 RVA: 0x00156ECC File Offset: 0x001550CC
		public virtual int GetEdgeSearchMode()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetEdgeSearchMode_08(base.GetCppThis());
		}

		// Token: 0x0600F6B2 RID: 63154
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetEdgeSearchModeAsString_09(HandleRef pThis);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6B3 RID: 63155 RVA: 0x00156EEC File Offset: 0x001550EC
		public string GetEdgeSearchModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectPolyData.vtkSelectPolyData_GetEdgeSearchModeAsString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F6B4 RID: 63156
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetEdgeSearchModeMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6B5 RID: 63157 RVA: 0x00156F28 File Offset: 0x00155128
		public virtual int GetEdgeSearchModeMaxValue()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetEdgeSearchModeMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600F6B6 RID: 63158
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetEdgeSearchModeMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6B7 RID: 63159 RVA: 0x00156F48 File Offset: 0x00155148
		public virtual int GetEdgeSearchModeMinValue()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetEdgeSearchModeMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600F6B8 RID: 63160
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetGenerateSelectionScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag to control behavior of the filter. If
		/// GenerateSelectionScalars is on, then the output of the filter
		/// is the same as the input, except that scalars are generated.
		/// If off, the filter outputs the cells laying inside the loop, and
		/// does not generate scalars.
		/// </summary>
		// Token: 0x0600F6B9 RID: 63161 RVA: 0x00156F68 File Offset: 0x00155168
		public virtual int GetGenerateSelectionScalars()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetGenerateSelectionScalars_12(base.GetCppThis());
		}

		// Token: 0x0600F6BA RID: 63162
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetGenerateUnselectedOutput_13(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's not been selected.
		/// </summary>
		// Token: 0x0600F6BB RID: 63163 RVA: 0x00156F88 File Offset: 0x00155188
		public virtual int GetGenerateUnselectedOutput()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetGenerateUnselectedOutput_13(base.GetCppThis());
		}

		// Token: 0x0600F6BC RID: 63164
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetInsideOut_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the mesh within the loop is
		/// extracted. When on, the mesh outside the loop is extracted.
		/// </summary>
		// Token: 0x0600F6BD RID: 63165 RVA: 0x00156FA8 File Offset: 0x001551A8
		public virtual int GetInsideOut()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetInsideOut_14(base.GetCppThis());
		}

		// Token: 0x0600F6BE RID: 63166
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetLoop_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the array of point coordinates defining the loop. There must
		/// be at least three points used to define a loop.
		/// </summary>
		// Token: 0x0600F6BF RID: 63167 RVA: 0x00156FC8 File Offset: 0x001551C8
		public virtual vtkPoints GetLoop()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetLoop_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F6C0 RID: 63168
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSelectPolyData_GetMTime_16(HandleRef pThis);

		/// <summary>
		/// Return the (mesh) edges of the selection region.
		/// </summary>
		// Token: 0x0600F6C1 RID: 63169 RVA: 0x00157038 File Offset: 0x00155238
		public override ulong GetMTime()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetMTime_16(base.GetCppThis());
		}

		// Token: 0x0600F6C2 RID: 63170
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectPolyData_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6C3 RID: 63171 RVA: 0x00157058 File Offset: 0x00155258
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600F6C4 RID: 63172
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelectPolyData_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6C5 RID: 63173 RVA: 0x00157078 File Offset: 0x00155278
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600F6C6 RID: 63174
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetSelectionEdges_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the (mesh) edges of the selection region.
		/// </summary>
		// Token: 0x0600F6C7 RID: 63175 RVA: 0x00157094 File Offset: 0x00155294
		public vtkPolyData GetSelectionEdges()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetSelectionEdges_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F6C8 RID: 63176
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetSelectionMode_20(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6C9 RID: 63177 RVA: 0x00157104 File Offset: 0x00155304
		public virtual int GetSelectionMode()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetSelectionMode_20(base.GetCppThis());
		}

		// Token: 0x0600F6CA RID: 63178
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetSelectionModeAsString_21(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6CB RID: 63179 RVA: 0x00157124 File Offset: 0x00155324
		public string GetSelectionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectPolyData.vtkSelectPolyData_GetSelectionModeAsString_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F6CC RID: 63180
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetSelectionModeMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6CD RID: 63181 RVA: 0x00157160 File Offset: 0x00155360
		public virtual int GetSelectionModeMaxValue()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetSelectionModeMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600F6CE RID: 63182
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_GetSelectionModeMinValue_23(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6CF RID: 63183 RVA: 0x00157180 File Offset: 0x00155380
		public virtual int GetSelectionModeMinValue()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetSelectionModeMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600F6D0 RID: 63184
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetSelectionScalarsArrayName_24(HandleRef pThis);

		/// <summary>
		/// Name of the Selection Scalars array. Default is "Selection".
		/// </summary>
		// Token: 0x0600F6D1 RID: 63185 RVA: 0x001571A0 File Offset: 0x001553A0
		public virtual string GetSelectionScalarsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSelectPolyData.vtkSelectPolyData_GetSelectionScalarsArrayName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F6D2 RID: 63186
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetUnselectedOutput_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return output that hasn't been selected (if GenreateUnselectedOutput is
		/// enabled).
		/// </summary>
		// Token: 0x0600F6D3 RID: 63187 RVA: 0x001571DC File Offset: 0x001553DC
		public vtkPolyData GetUnselectedOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetUnselectedOutput_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F6D4 RID: 63188
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_GetUnselectedOutputPort_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return output port that hasn't been selected (if GenreateUnselectedOutput is
		/// enabled).
		/// </summary>
		// Token: 0x0600F6D5 RID: 63189 RVA: 0x0015724C File Offset: 0x0015544C
		public vtkAlgorithmOutput GetUnselectedOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetUnselectedOutputPort_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600F6D6 RID: 63190
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_InsideOutOff_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the mesh within the loop is
		/// extracted. When on, the mesh outside the loop is extracted.
		/// </summary>
		// Token: 0x0600F6D7 RID: 63191 RVA: 0x001572BB File Offset: 0x001554BB
		public virtual void InsideOutOff()
		{
			vtkSelectPolyData.vtkSelectPolyData_InsideOutOff_27(base.GetCppThis());
		}

		// Token: 0x0600F6D8 RID: 63192
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_InsideOutOn_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the mesh within the loop is
		/// extracted. When on, the mesh outside the loop is extracted.
		/// </summary>
		// Token: 0x0600F6D9 RID: 63193 RVA: 0x001572CA File Offset: 0x001554CA
		public virtual void InsideOutOn()
		{
			vtkSelectPolyData.vtkSelectPolyData_InsideOutOn_28(base.GetCppThis());
		}

		// Token: 0x0600F6DA RID: 63194
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6DB RID: 63195 RVA: 0x001572DC File Offset: 0x001554DC
		public override int IsA(string type)
		{
			return vtkSelectPolyData.vtkSelectPolyData_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600F6DC RID: 63196
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelectPolyData_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6DD RID: 63197 RVA: 0x001572FC File Offset: 0x001554FC
		public new static int IsTypeOf(string type)
		{
			return vtkSelectPolyData.vtkSelectPolyData_IsTypeOf_30(type);
		}

		// Token: 0x0600F6DE RID: 63198
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6DF RID: 63199 RVA: 0x00157318 File Offset: 0x00155518
		public new vtkSelectPolyData NewInstance()
		{
			vtkSelectPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F6E0 RID: 63200
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelectPolyData_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with InsideOut turned off, and
		/// GenerateSelectionScalars turned off. The unselected output
		/// is not generated, and the inside mode is the smallest region.
		/// </summary>
		// Token: 0x0600F6E1 RID: 63201 RVA: 0x00157374 File Offset: 0x00155574
		public new static vtkSelectPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkSelectPolyData vtkSelectPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectPolyData = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectPolyData.Register(null);
				}
			}
			return vtkSelectPolyData;
		}

		// Token: 0x0600F6E2 RID: 63202
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetClosestPoint_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the point used in SelectionModeToClosestPointRegion.
		/// </summary>
		// Token: 0x0600F6E3 RID: 63203 RVA: 0x001573F3 File Offset: 0x001555F3
		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetClosestPoint_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F6E4 RID: 63204
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetClosestPoint_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the point used in SelectionModeToClosestPointRegion.
		/// </summary>
		// Token: 0x0600F6E5 RID: 63205 RVA: 0x00157405 File Offset: 0x00155605
		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetClosestPoint_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6E6 RID: 63206
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetEdgeSearchMode_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6E7 RID: 63207 RVA: 0x00157415 File Offset: 0x00155615
		public virtual void SetEdgeSearchMode(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetEdgeSearchMode_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6E8 RID: 63208
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetEdgeSearchModeToDijkstra_37(HandleRef pThis);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6E9 RID: 63209 RVA: 0x00157425 File Offset: 0x00155625
		public void SetEdgeSearchModeToDijkstra()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetEdgeSearchModeToDijkstra_37(base.GetCppThis());
		}

		// Token: 0x0600F6EA RID: 63210
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetEdgeSearchModeToGreedy_38(HandleRef pThis);

		/// <summary>
		/// Set the edge search mode. VTK_GREEDY_EDGE_SEARCH is simple and fast,
		/// VTK_DIJKSTRA_EDGE_SEARCH is more robust and guaranteed to provide
		/// shortest path between loop points.
		/// If the algorithm fails with "Can't follow edge" error then switch to
		/// Dijkstra method.
		/// The default is VTK_GREEDY_EDGE_SEARCH for backward compatibility.
		/// </summary>
		// Token: 0x0600F6EB RID: 63211 RVA: 0x00157434 File Offset: 0x00155634
		public void SetEdgeSearchModeToGreedy()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetEdgeSearchModeToGreedy_38(base.GetCppThis());
		}

		// Token: 0x0600F6EC RID: 63212
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetGenerateSelectionScalars_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag to control behavior of the filter. If
		/// GenerateSelectionScalars is on, then the output of the filter
		/// is the same as the input, except that scalars are generated.
		/// If off, the filter outputs the cells laying inside the loop, and
		/// does not generate scalars.
		/// </summary>
		// Token: 0x0600F6ED RID: 63213 RVA: 0x00157443 File Offset: 0x00155643
		public virtual void SetGenerateSelectionScalars(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetGenerateSelectionScalars_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6EE RID: 63214
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetGenerateUnselectedOutput_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's not been selected.
		/// </summary>
		// Token: 0x0600F6EF RID: 63215 RVA: 0x00157453 File Offset: 0x00155653
		public virtual void SetGenerateUnselectedOutput(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetGenerateUnselectedOutput_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6F0 RID: 63216
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetInsideOut_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, the mesh within the loop is
		/// extracted. When on, the mesh outside the loop is extracted.
		/// </summary>
		// Token: 0x0600F6F1 RID: 63217 RVA: 0x00157463 File Offset: 0x00155663
		public virtual void SetInsideOut(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetInsideOut_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6F2 RID: 63218
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetLoop_42(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the array of point coordinates defining the loop. There must
		/// be at least three points used to define a loop.
		/// </summary>
		// Token: 0x0600F6F3 RID: 63219 RVA: 0x00157474 File Offset: 0x00155674
		public virtual void SetLoop(vtkPoints arg0)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetLoop_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600F6F4 RID: 63220
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetSelectionMode_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6F5 RID: 63221 RVA: 0x001574A3 File Offset: 0x001556A3
		public virtual void SetSelectionMode(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionMode_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F6F6 RID: 63222
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetSelectionModeToClosestPointRegion_44(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6F7 RID: 63223 RVA: 0x001574B3 File Offset: 0x001556B3
		public void SetSelectionModeToClosestPointRegion()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionModeToClosestPointRegion_44(base.GetCppThis());
		}

		// Token: 0x0600F6F8 RID: 63224
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetSelectionModeToLargestRegion_45(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6F9 RID: 63225 RVA: 0x001574C2 File Offset: 0x001556C2
		public void SetSelectionModeToLargestRegion()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionModeToLargestRegion_45(base.GetCppThis());
		}

		// Token: 0x0600F6FA RID: 63226
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetSelectionModeToSmallestRegion_46(HandleRef pThis);

		/// <summary>
		/// Control how inside/outside of loop is defined.
		/// </summary>
		// Token: 0x0600F6FB RID: 63227 RVA: 0x001574D1 File Offset: 0x001556D1
		public void SetSelectionModeToSmallestRegion()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionModeToSmallestRegion_46(base.GetCppThis());
		}

		// Token: 0x0600F6FC RID: 63228
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelectPolyData_SetSelectionScalarsArrayName_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Name of the Selection Scalars array. Default is "Selection".
		/// </summary>
		// Token: 0x0600F6FD RID: 63229 RVA: 0x001574E0 File Offset: 0x001556E0
		public virtual void SetSelectionScalarsArrayName(string _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionScalarsArrayName_47(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011EF RID: 4591
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F0 RID: 4592
		public new static readonly string MRClassNameKey = "class vtkSelectPolyData";
	}
}
