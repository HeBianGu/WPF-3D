using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConvertSelectionDomain
	/// </summary>
	/// <remarks>
	///    Convert a selection from one domain to another
	///
	///
	/// vtkConvertSelectionDomain converts a selection from one domain to another
	/// using known domain mappings. The domain mappings are described by a
	/// vtkMultiBlockDataSet containing one or more vtkTables.
	///
	/// The first input port is for the input selection (or collection of annotations
	/// in a vtkAnnotationLayers object), while the second port
	/// is for the multi-block of mappings, and the third port is for the
	/// data that is being selected on.
	///
	/// If the second or third port is not set, this filter will pass the
	/// selection/annotation to the output unchanged.
	///
	/// The second output is the selection associated with the "current annotation"
	/// normally representing the current interactive selection.
	/// </remarks>
	// Token: 0x020002A6 RID: 678
	public class vtkConvertSelectionDomain : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007A10 RID: 31248 RVA: 0x000AFF13 File Offset: 0x000AE113
		static vtkConvertSelectionDomain()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertSelectionDomain.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertSelectionDomain"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007A11 RID: 31249 RVA: 0x000AFF3B File Offset: 0x000AE13B
		public vtkConvertSelectionDomain(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007A12 RID: 31250
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelectionDomain_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A13 RID: 31251 RVA: 0x000AFF4C File Offset: 0x000AE14C
		public new static vtkConvertSelectionDomain New()
		{
			vtkConvertSelectionDomain result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelectionDomain.vtkConvertSelectionDomain_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelectionDomain)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A14 RID: 31252 RVA: 0x000AFFA0 File Offset: 0x000AE1A0
		public vtkConvertSelectionDomain() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvertSelectionDomain.vtkConvertSelectionDomain_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007A15 RID: 31253 RVA: 0x000AFFE4 File Offset: 0x000AE1E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007A16 RID: 31254
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertSelectionDomain_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A17 RID: 31255 RVA: 0x000AFFF0 File Offset: 0x000AE1F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvertSelectionDomain.vtkConvertSelectionDomain_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007A18 RID: 31256
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertSelectionDomain_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A19 RID: 31257 RVA: 0x000B0010 File Offset: 0x000AE210
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvertSelectionDomain.vtkConvertSelectionDomain_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06007A1A RID: 31258
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertSelectionDomain_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A1B RID: 31259 RVA: 0x000B002C File Offset: 0x000AE22C
		public override int IsA(string type)
		{
			return vtkConvertSelectionDomain.vtkConvertSelectionDomain_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06007A1C RID: 31260
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertSelectionDomain_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A1D RID: 31261 RVA: 0x000B004C File Offset: 0x000AE24C
		public new static int IsTypeOf(string type)
		{
			return vtkConvertSelectionDomain.vtkConvertSelectionDomain_IsTypeOf_04(type);
		}

		// Token: 0x06007A1E RID: 31262
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelectionDomain_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A1F RID: 31263 RVA: 0x000B0068 File Offset: 0x000AE268
		public new vtkConvertSelectionDomain NewInstance()
		{
			vtkConvertSelectionDomain result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelectionDomain.vtkConvertSelectionDomain_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelectionDomain)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007A20 RID: 31264
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertSelectionDomain_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A21 RID: 31265 RVA: 0x000B00C4 File Offset: 0x000AE2C4
		public new static vtkConvertSelectionDomain SafeDownCast(vtkObjectBase o)
		{
			vtkConvertSelectionDomain vtkConvertSelectionDomain = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertSelectionDomain.vtkConvertSelectionDomain_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertSelectionDomain = (vtkConvertSelectionDomain)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertSelectionDomain.Register(null);
				}
			}
			return vtkConvertSelectionDomain;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A5C RID: 2652
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertSelectionDomain";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A5D RID: 2653
		public new static readonly string MRClassNameKey = "class vtkConvertSelectionDomain";
	}
}
