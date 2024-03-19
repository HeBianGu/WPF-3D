using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPipelineGraphSource
	/// </summary>
	/// <remarks>
	///    a graph constructed from a VTK pipeline
	///
	///
	/// </remarks>
	// Token: 0x02000689 RID: 1673
	public class vtkPipelineGraphSource : vtkDirectedGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011F55 RID: 73557 RVA: 0x00192528 File Offset: 0x00190728
		static vtkPipelineGraphSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPipelineGraphSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPipelineGraphSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011F56 RID: 73558 RVA: 0x00192550 File Offset: 0x00190750
		public vtkPipelineGraphSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011F57 RID: 73559
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPipelineGraphSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F58 RID: 73560 RVA: 0x00192560 File Offset: 0x00190760
		public new static vtkPipelineGraphSource New()
		{
			vtkPipelineGraphSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPipelineGraphSource.vtkPipelineGraphSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPipelineGraphSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F59 RID: 73561 RVA: 0x001925B4 File Offset: 0x001907B4
		public vtkPipelineGraphSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPipelineGraphSource.vtkPipelineGraphSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011F5A RID: 73562 RVA: 0x001925F8 File Offset: 0x001907F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011F5B RID: 73563
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPipelineGraphSource_AddSink_01(HandleRef pThis, HandleRef sink);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F5C RID: 73564 RVA: 0x00192604 File Offset: 0x00190804
		public void AddSink(vtkObject sink)
		{
			vtkPipelineGraphSource.vtkPipelineGraphSource_AddSink_01(base.GetCppThis(), (sink == null) ? default(HandleRef) : sink.GetCppThis());
		}

		// Token: 0x06011F5D RID: 73565
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPipelineGraphSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F5E RID: 73566 RVA: 0x00192634 File Offset: 0x00190834
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPipelineGraphSource.vtkPipelineGraphSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011F5F RID: 73567
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPipelineGraphSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F60 RID: 73568 RVA: 0x00192654 File Offset: 0x00190854
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPipelineGraphSource.vtkPipelineGraphSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011F61 RID: 73569
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPipelineGraphSource_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F62 RID: 73570 RVA: 0x00192670 File Offset: 0x00190870
		public override int IsA(string type)
		{
			return vtkPipelineGraphSource.vtkPipelineGraphSource_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011F63 RID: 73571
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPipelineGraphSource_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F64 RID: 73572 RVA: 0x00192690 File Offset: 0x00190890
		public new static int IsTypeOf(string type)
		{
			return vtkPipelineGraphSource.vtkPipelineGraphSource_IsTypeOf_05(type);
		}

		// Token: 0x06011F65 RID: 73573
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPipelineGraphSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F66 RID: 73574 RVA: 0x001926AC File Offset: 0x001908AC
		public new vtkPipelineGraphSource NewInstance()
		{
			vtkPipelineGraphSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPipelineGraphSource.vtkPipelineGraphSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPipelineGraphSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011F67 RID: 73575
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPipelineGraphSource_RemoveSink_08(HandleRef pThis, HandleRef sink);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F68 RID: 73576 RVA: 0x00192708 File Offset: 0x00190908
		public void RemoveSink(vtkObject sink)
		{
			vtkPipelineGraphSource.vtkPipelineGraphSource_RemoveSink_08(base.GetCppThis(), (sink == null) ? default(HandleRef) : sink.GetCppThis());
		}

		// Token: 0x06011F69 RID: 73577
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPipelineGraphSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F6A RID: 73578 RVA: 0x00192738 File Offset: 0x00190938
		public new static vtkPipelineGraphSource SafeDownCast(vtkObjectBase o)
		{
			vtkPipelineGraphSource vtkPipelineGraphSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPipelineGraphSource.vtkPipelineGraphSource_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPipelineGraphSource = (vtkPipelineGraphSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPipelineGraphSource.Register(null);
				}
			}
			return vtkPipelineGraphSource;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014BB RID: 5307
		public new const string MRFullTypeName = "Kitware.VTK.vtkPipelineGraphSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014BC RID: 5308
		public new static readonly string MRClassNameKey = "class vtkPipelineGraphSource";
	}
}
