using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeFieldAggregator
	/// </summary>
	/// <remarks>
	///    aggregate field values from the leaves up the tree
	///
	///
	/// vtkTreeFieldAggregator may be used to assign sizes to all the vertices in the
	/// tree, based on the sizes of the leaves.  The size of a vertex will equal
	/// the sum of the sizes of the child vertices.  If you have a data array with
	/// values for all leaves, you may specify that array, and the values will
	/// be filled in for interior tree vertices.  If you do not yet have an array,
	/// you may tell the filter to create a new array, assuming that the size
	/// of each leaf vertex is 1.  You may optionally set a flag to first take the
	/// log of all leaf values before aggregating.
	/// </remarks>
	// Token: 0x0200069E RID: 1694
	public class vtkTreeFieldAggregator : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012203 RID: 74243 RVA: 0x0019627B File Offset: 0x0019447B
		static vtkTreeFieldAggregator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeFieldAggregator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeFieldAggregator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012204 RID: 74244 RVA: 0x001962A3 File Offset: 0x001944A3
		public vtkTreeFieldAggregator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012205 RID: 74245
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeFieldAggregator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012206 RID: 74246 RVA: 0x001962B4 File Offset: 0x001944B4
		public new static vtkTreeFieldAggregator New()
		{
			vtkTreeFieldAggregator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeFieldAggregator.vtkTreeFieldAggregator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012207 RID: 74247 RVA: 0x00196308 File Offset: 0x00194508
		public vtkTreeFieldAggregator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeFieldAggregator.vtkTreeFieldAggregator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012208 RID: 74248 RVA: 0x0019634C File Offset: 0x0019454C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012209 RID: 74249
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeFieldAggregator_GetField_01(HandleRef pThis);

		/// <summary>
		/// The field to aggregate.  If this is a string array, the entries are converted to double.
		/// TODO: Remove this field and use the ArrayToProcess in vtkAlgorithm.
		/// </summary>
		// Token: 0x0601220A RID: 74250 RVA: 0x00196358 File Offset: 0x00194558
		public virtual string GetField()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetField_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601220B RID: 74251
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeFieldAggregator_GetLeafVertexUnitSize_02(HandleRef pThis);

		/// <summary>
		/// If set, the algorithm will assume a size of 1 for each leaf vertex.
		/// </summary>
		// Token: 0x0601220C RID: 74252 RVA: 0x00196394 File Offset: 0x00194594
		public virtual bool GetLeafVertexUnitSize()
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetLeafVertexUnitSize_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0601220D RID: 74253
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeFieldAggregator_GetLogScale_03(HandleRef pThis);

		/// <summary>
		/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
		/// </summary>
		// Token: 0x0601220E RID: 74254 RVA: 0x001963BC File Offset: 0x001945BC
		public virtual bool GetLogScale()
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetLogScale_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601220F RID: 74255
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeFieldAggregator_GetMinValue_04(HandleRef pThis);

		/// <summary>
		/// If the value of the vertex is less than MinValue then consider it's value to be minVal.
		/// </summary>
		// Token: 0x06012210 RID: 74256 RVA: 0x001963E4 File Offset: 0x001945E4
		public virtual double GetMinValue()
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetMinValue_04(base.GetCppThis());
		}

		// Token: 0x06012211 RID: 74257
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeFieldAggregator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012212 RID: 74258 RVA: 0x00196404 File Offset: 0x00194604
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06012213 RID: 74259
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeFieldAggregator_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012214 RID: 74260 RVA: 0x00196424 File Offset: 0x00194624
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06012215 RID: 74261
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeFieldAggregator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012216 RID: 74262 RVA: 0x00196440 File Offset: 0x00194640
		public override int IsA(string type)
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06012217 RID: 74263
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeFieldAggregator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012218 RID: 74264 RVA: 0x00196460 File Offset: 0x00194660
		public new static int IsTypeOf(string type)
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_IsTypeOf_08(type);
		}

		// Token: 0x06012219 RID: 74265
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_LeafVertexUnitSizeOff_09(HandleRef pThis);

		/// <summary>
		/// If set, the algorithm will assume a size of 1 for each leaf vertex.
		/// </summary>
		// Token: 0x0601221A RID: 74266 RVA: 0x0019647A File Offset: 0x0019467A
		public virtual void LeafVertexUnitSizeOff()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LeafVertexUnitSizeOff_09(base.GetCppThis());
		}

		// Token: 0x0601221B RID: 74267
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_LeafVertexUnitSizeOn_10(HandleRef pThis);

		/// <summary>
		/// If set, the algorithm will assume a size of 1 for each leaf vertex.
		/// </summary>
		// Token: 0x0601221C RID: 74268 RVA: 0x00196489 File Offset: 0x00194689
		public virtual void LeafVertexUnitSizeOn()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LeafVertexUnitSizeOn_10(base.GetCppThis());
		}

		// Token: 0x0601221D RID: 74269
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_LogScaleOff_11(HandleRef pThis);

		/// <summary>
		/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
		/// </summary>
		// Token: 0x0601221E RID: 74270 RVA: 0x00196498 File Offset: 0x00194698
		public virtual void LogScaleOff()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LogScaleOff_11(base.GetCppThis());
		}

		// Token: 0x0601221F RID: 74271
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_LogScaleOn_12(HandleRef pThis);

		/// <summary>
		/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
		/// </summary>
		// Token: 0x06012220 RID: 74272 RVA: 0x001964A7 File Offset: 0x001946A7
		public virtual void LogScaleOn()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LogScaleOn_12(base.GetCppThis());
		}

		// Token: 0x06012221 RID: 74273
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeFieldAggregator_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012222 RID: 74274 RVA: 0x001964B8 File Offset: 0x001946B8
		public new vtkTreeFieldAggregator NewInstance()
		{
			vtkTreeFieldAggregator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeFieldAggregator.vtkTreeFieldAggregator_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012223 RID: 74275
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeFieldAggregator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012224 RID: 74276 RVA: 0x00196514 File Offset: 0x00194714
		public new static vtkTreeFieldAggregator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeFieldAggregator vtkTreeFieldAggregator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeFieldAggregator.vtkTreeFieldAggregator_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeFieldAggregator = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeFieldAggregator.Register(null);
				}
			}
			return vtkTreeFieldAggregator;
		}

		// Token: 0x06012225 RID: 74277
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_SetField_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The field to aggregate.  If this is a string array, the entries are converted to double.
		/// TODO: Remove this field and use the ArrayToProcess in vtkAlgorithm.
		/// </summary>
		// Token: 0x06012226 RID: 74278 RVA: 0x00196593 File Offset: 0x00194793
		public virtual void SetField(string _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetField_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06012227 RID: 74279
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_SetLeafVertexUnitSize_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set, the algorithm will assume a size of 1 for each leaf vertex.
		/// </summary>
		// Token: 0x06012228 RID: 74280 RVA: 0x001965A3 File Offset: 0x001947A3
		public virtual void SetLeafVertexUnitSize(bool _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetLeafVertexUnitSize_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012229 RID: 74281
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_SetLogScale_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set, the leaf values in the tree will be logarithmically scaled (base 10).
		/// </summary>
		// Token: 0x0601222A RID: 74282 RVA: 0x001965BB File Offset: 0x001947BB
		public virtual void SetLogScale(bool _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetLogScale_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601222B RID: 74283
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeFieldAggregator_SetMinValue_19(HandleRef pThis, double _arg);

		/// <summary>
		/// If the value of the vertex is less than MinValue then consider it's value to be minVal.
		/// </summary>
		// Token: 0x0601222C RID: 74284 RVA: 0x001965D3 File Offset: 0x001947D3
		public virtual void SetMinValue(double _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetMinValue_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014EA RID: 5354
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeFieldAggregator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014EB RID: 5355
		public new static readonly string MRClassNameKey = "class vtkTreeFieldAggregator";
	}
}
