using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThresholdGraph
	/// </summary>
	/// <remarks>
	///    Returns a subgraph of a vtkGraph.
	///
	///
	/// Requires input array, lower and upper threshold. This filter than
	/// extracts the subgraph based on these three parameters.
	/// </remarks>
	// Token: 0x02000698 RID: 1688
	public class vtkThresholdGraph : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012159 RID: 74073 RVA: 0x001951B3 File Offset: 0x001933B3
		static vtkThresholdGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601215A RID: 74074 RVA: 0x001951DB File Offset: 0x001933DB
		public vtkThresholdGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601215B RID: 74075
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601215C RID: 74076 RVA: 0x001951EC File Offset: 0x001933EC
		public new static vtkThresholdGraph New()
		{
			vtkThresholdGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdGraph.vtkThresholdGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601215D RID: 74077 RVA: 0x00195240 File Offset: 0x00193440
		public vtkThresholdGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThresholdGraph.vtkThresholdGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601215E RID: 74078 RVA: 0x00195284 File Offset: 0x00193484
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601215F RID: 74079
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThresholdGraph_GetLowerThreshold_01(HandleRef pThis);

		/// <summary>
		/// Get/Set lower threshold. This would be the value against which
		/// edge or vertex data array value will be compared.
		/// </summary>
		// Token: 0x06012160 RID: 74080 RVA: 0x00195290 File Offset: 0x00193490
		public virtual double GetLowerThreshold()
		{
			return vtkThresholdGraph.vtkThresholdGraph_GetLowerThreshold_01(base.GetCppThis());
		}

		// Token: 0x06012161 RID: 74081
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdGraph_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012162 RID: 74082 RVA: 0x001952B0 File Offset: 0x001934B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThresholdGraph.vtkThresholdGraph_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012163 RID: 74083
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThresholdGraph_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012164 RID: 74084 RVA: 0x001952D0 File Offset: 0x001934D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThresholdGraph.vtkThresholdGraph_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012165 RID: 74085
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkThresholdGraph_GetUpperThreshold_04(HandleRef pThis);

		/// <summary>
		/// Get/Set upper threshold. This would be the value against which
		/// edge or vertex data array value will be compared.
		/// </summary>
		// Token: 0x06012166 RID: 74086 RVA: 0x001952EC File Offset: 0x001934EC
		public virtual double GetUpperThreshold()
		{
			return vtkThresholdGraph.vtkThresholdGraph_GetUpperThreshold_04(base.GetCppThis());
		}

		// Token: 0x06012167 RID: 74087
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdGraph_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012168 RID: 74088 RVA: 0x0019530C File Offset: 0x0019350C
		public override int IsA(string type)
		{
			return vtkThresholdGraph.vtkThresholdGraph_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012169 RID: 74089
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThresholdGraph_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601216A RID: 74090 RVA: 0x0019532C File Offset: 0x0019352C
		public new static int IsTypeOf(string type)
		{
			return vtkThresholdGraph.vtkThresholdGraph_IsTypeOf_06(type);
		}

		// Token: 0x0601216B RID: 74091
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdGraph_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601216C RID: 74092 RVA: 0x00195348 File Offset: 0x00193548
		public new vtkThresholdGraph NewInstance()
		{
			vtkThresholdGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdGraph.vtkThresholdGraph_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601216D RID: 74093
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThresholdGraph_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601216E RID: 74094 RVA: 0x001953A4 File Offset: 0x001935A4
		public new static vtkThresholdGraph SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdGraph vtkThresholdGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThresholdGraph.vtkThresholdGraph_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdGraph = (vtkThresholdGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdGraph.Register(null);
				}
			}
			return vtkThresholdGraph;
		}

		// Token: 0x0601216F RID: 74095
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdGraph_SetLowerThreshold_10(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set lower threshold. This would be the value against which
		/// edge or vertex data array value will be compared.
		/// </summary>
		// Token: 0x06012170 RID: 74096 RVA: 0x00195423 File Offset: 0x00193623
		public virtual void SetLowerThreshold(double _arg)
		{
			vtkThresholdGraph.vtkThresholdGraph_SetLowerThreshold_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06012171 RID: 74097
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThresholdGraph_SetUpperThreshold_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set upper threshold. This would be the value against which
		/// edge or vertex data array value will be compared.
		/// </summary>
		// Token: 0x06012172 RID: 74098 RVA: 0x00195433 File Offset: 0x00193633
		public virtual void SetUpperThreshold(double _arg)
		{
			vtkThresholdGraph.vtkThresholdGraph_SetUpperThreshold_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014DB RID: 5339
		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014DC RID: 5340
		public new static readonly string MRClassNameKey = "class vtkThresholdGraph";
	}
}
